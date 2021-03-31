import 'package:flutter/material.dart';
import 'ChangePass_Screen.dart';
import 'UserInfo.dart';
import 'size_config.dart';
import 'info.dart';
import 'profile_menu_item.dart';

class Body extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      child: Column(
        children: <Widget>[
          Info(
            image: "assets/images/pic.jpg",
            name: "Onur Sarı",
            email: "onurssari@gmail.com",
          ),
          SizedBox(height: SizeConfig.defaultSize * 2), //20
          ProfileMenuItem(
            iconSrc: "assets/icons/bookmark_fill.svg",
            title: "Change Password",
            press: () {
              Navigator.push(context,MaterialPageRoute(builder: (context)=>ChangePassword()),);
            },
          ),
          ProfileMenuItem(
            iconSrc:"assets/icons/info.svg",
            title: "User Info",
            press: () {Navigator.push(context,MaterialPageRoute(builder: (context)=> userInfo()),);},
          ),
          ProfileMenuItem(
            iconSrc: "assets/icons/language.svg",
            title: "Change Language",
            press: () {},
          ),
          ProfileMenuItem(
            iconSrc: "assets/icons/info.svg",
            title: "Help",
            press: () {},
          ),
        ],
      ),
    );
  }
}