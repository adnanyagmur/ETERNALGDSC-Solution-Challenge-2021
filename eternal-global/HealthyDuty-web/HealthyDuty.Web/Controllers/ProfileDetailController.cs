﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthyDuty.Data.Entity;
using HealthyDuty.Web.Business.Enums;
using HealthyDuty.Web.Business.Interfaces;
using HealthyDuty.Web.Filters;
using HealthyDuty.Web.Models.ProfileDetail;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HealthyDuty.Web.Controllers
{
    public class ProfileDetailController : Controller
    {
        private readonly IProfileDetailService _profileDetailService;
        private readonly IProfileService _profileService;

        public ProfileDetailController(IProfileDetailService profileDetailService, IProfileService profileService)
        {
            _profileDetailService = profileDetailService;
            _profileService = profileService;
        }

        [AppAuthorizeFilter(AuthCodeStatic.PAGE_PROFILEDETAIL_BATCHEDIT)]
        public ActionResult BatchEdit()
        {
            BatchEditViewModel model = new BatchEditViewModel();
            model.ProfileSelectList = GetProfileSelectList();
            model.AuthList = new List<AuthCheckViewModel>();
            model.AuthWhichIsNotIncludeList = new List<AuthCheckViewModel>();
            return View(model);
        }

        [HttpPost]
        [AppAuthorizeFilter(AuthCodeStatic.PAGE_PROFILEDETAIL_BATCHEDIT)]
        public ActionResult BatchEdit(BatchEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                if (model.ProfileId.HasValue)
                {
                    model.AuthList = GetAllAuthByProfileId( model.ProfileId.Value);
                    model.AuthWhichIsNotIncludeList = GetAllAuthByProfileIdWhichIsNotIncluded( model.ProfileId.Value);
                }
                else
                {
                    model.AuthList = new List<AuthCheckViewModel>();
                    model.AuthWhichIsNotIncludeList = new List<AuthCheckViewModel>();
                }
                return View(model);
            }

            if (model.SubmitType == "Add")
            {
                if (model.AuthWhichIsNotIncludeList != null)
                {
                    ModelState.Clear();
                    List<AuthCheckViewModel> record = model.AuthWhichIsNotIncludeList.Where(x => x.Checked == true).ToList();
                    if (record != null)
                    {
                        foreach (var item in record)
                        {
                            ProfileDetail profileDetail = new ProfileDetail();
                            profileDetail.AuthId = item.Id;
                            profileDetail.ProfileId = model.ProfileId.Value;
                            _profileDetailService.Add( profileDetail);
                        }
                    }
                }
            }
            if (model.SubmitType == "Delete")
            {
                if (model.AuthList != null)
                {
                    ModelState.Clear();
                    List<AuthCheckViewModel> record = model.AuthList.Where(x => x.Checked == true).ToList();
                    if (record != null)
                    {
                        foreach (var item in record)
                        {
                            var apiResponseModel = _profileDetailService.DeleteByProfileIdAndAuthId(model.ProfileId.Value, item.Id);
                        }
                    }
                }
            }


            model.ProfileSelectList = GetProfileSelectList();
            if (model.ProfileId.HasValue)
            {
                model.AuthList = GetAllAuthByProfileId(model.ProfileId.Value);
                model.AuthWhichIsNotIncludeList = GetAllAuthByProfileIdWhichIsNotIncluded( model.ProfileId.Value);
            }
            else
            {
                model.AuthList = new List<AuthCheckViewModel>();
                model.AuthWhichIsNotIncludeList = new List<AuthCheckViewModel>();
            }
            return View(model);
        }

        [NonAction]
        private List<AuthCheckViewModel> GetAllAuthByProfileId( int profileId)
        {
            //profile ait yetki kayıtları listelenir
            List<AuthCheckViewModel> resultList = new List<AuthCheckViewModel>();
            resultList = _profileDetailService.GetAllAuthByProfileId(profileId).Select(a => new AuthCheckViewModel() { Id = a.Id, Name = a.Name, Checked = false, Code = a.Code }).ToList();
            return resultList;
        }

        [NonAction]
        private List<AuthCheckViewModel> GetAllAuthByProfileIdWhichIsNotIncluded(int profileId)
        {
            //profile ait olmayan yetki kayıtları listelenir
            List<AuthCheckViewModel> resultList = new List<AuthCheckViewModel>();
            resultList = _profileDetailService.GetAllAuthByProfileIdWhichIsNotIncluded(profileId).Select(a => new AuthCheckViewModel() { Id = a.Id, Name = a.Name, Checked = false, Code = a.Code }).ToList();
            return resultList;
        }

        [NonAction]
        private List<SelectListItem> GetProfileSelectList()
        {
            // profile select list
            List<SelectListItem> resultList = new List<SelectListItem>();
            try
            {
                resultList = _profileService.GetAll().OrderBy(r => r.Name).Select(r => new SelectListItem() { Value = r.Id.ToString(), Text = r.Name }).ToList();
            }
            catch
            {
                resultList = new List<SelectListItem>();
            }
            return resultList;
        }

    }
}
