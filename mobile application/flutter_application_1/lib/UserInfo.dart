import 'package:firebase_auth/firebase_auth.dart';
import 'package:flutter/material.dart';
import 'package:flutter_application_1/size_config.dart';
import 'package:fluttertoast/fluttertoast.dart';
import 'Firebase.dart';
import 'info.dart';

class userInfo extends StatefulWidget {
  @override
  _userInfoState createState() => _userInfoState();
}

class _userInfoState extends State<userInfo> {
  @override
  Widget build(BuildContext context) {
    fireBase database = new fireBase();

    SizeConfig().init(context);
    final ageController = TextEditingController();
    final surnameController = TextEditingController();
    final birthController = TextEditingController();
    final bloodController = TextEditingController();
    final nameController = TextEditingController();

    var _age,_name, _surname, _birth, _bloodGroup;
    var _TextFormFieldKey = GlobalKey();
    return Scaffold(
      appBar: AppBar(
        title: Text('User Info'),
        backgroundColor: Colors.red,
        elevation: 4.4,
      ),
      body: SingleChildScrollView(
        child: Padding(
          padding: const EdgeInsets.only(),
          child: Column(
            children: <Widget>[
              Info(
                image: "assets/images/pic.jpg",
                name: "Onur Sarı",
                email: "onurssari@gmail.com",
              ),
              SizedBox(height: SizeConfig.defaultSize * 2), //20
              Card(
                elevation: 4.0,
                color: Colors.white,
                margin: EdgeInsets.only(left: 20, right: 20),
                shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(10)),
                child: Padding(
                  padding: const EdgeInsets.all(10),
                  child: Column(
                    mainAxisAlignment: MainAxisAlignment.center,
                    children: <Widget>[
                      TextFormField(
                        controller: nameController,
                        onChanged: (value) {
                          _name = nameController.text;
                        },
                        style: TextStyle(color: Color(0xFF000000)),
                        cursorColor: Color(0xF9b9b9b),
                        keyboardType: TextInputType.text,
                        decoration: InputDecoration(
                          hintText: "Name:",
                          hintStyle: TextStyle(
                            color: Color(0xFF9b9b9b),
                            fontSize: 15,
                            fontWeight: FontWeight.bold,
                          ),
                        ),
                      ),
                      TextFormField(
                        controller: surnameController,
                        onChanged: (value) {
                          _surname =surnameController.text;
                        },
                        style: TextStyle(color: Color(0xFF000000)),
                        cursorColor: Color(0xF9b9b9b),
                        keyboardType: TextInputType.text,
                        decoration: InputDecoration(
                          hintText: "Surname:",
                          hintStyle: TextStyle(
                            color: Color(0xFF9b9b9b),
                            fontSize: 15,
                            fontWeight: FontWeight.bold,
                          ),
                        ),
                      ),
                      TextFormField(
                        controller: ageController,
                        onChanged: (value) {
                          _age = ageController.text;
                        },
                        style: TextStyle(color: Color(0xFF000000)),
                        cursorColor: Color(0xF9b9b9b),
                        keyboardType: TextInputType.text,
                        decoration: InputDecoration(
                          hintText: "Age:",
                          hintStyle: TextStyle(
                            color: Color(0xFF9b9b9b),
                            fontSize: 15,
                            fontWeight: FontWeight.bold,
                          ),
                        ),
                      ),
                      TextFormField(
                        controller: birthController,
                        onChanged: (value) {
                          _birth = birthController.text;
                        },
                        style: TextStyle(color: Color(0xFF000000)),
                        cursorColor: Color(0xF9b9b9b),
                        keyboardType: TextInputType.text,
                        decoration: InputDecoration(
                          hintText: "Birthday:",
                          hintStyle: TextStyle(
                            color: Color(0xFF9b9b9b),
                            fontSize: 15,
                            fontWeight: FontWeight.bold,
                          ),
                        ),
                      ),
                      TextFormField(
                        controller: bloodController,
                        onChanged: (value) {
                          _bloodGroup = bloodController.text;
                        },
                        style: TextStyle(color: Color(0xFF000000)),
                        cursorColor: Color(0xF9b9b9b),
                        keyboardType: TextInputType.text,
                        decoration: InputDecoration(
                          hintText: "Blood Group:",
                          hintStyle: TextStyle(
                            color: Color(0xFF9b9b9b),
                            fontSize: 15,
                            fontWeight: FontWeight.bold
                          ),
                        ),
                      ),
                      Padding(
                        padding: const EdgeInsets.all(10),
                        child: RaisedButton(
                          color: Colors.red[400],
                          shape: new RoundedRectangleBorder(
                              borderRadius: new BorderRadius.circular(10)),

                          //Profili Kaydet
                          onPressed: () async{
                           await database.addUser();

                            Fluttertoast.showToast(
                                msg: "Saved");
                          },
                          child: Padding(
                            padding: EdgeInsets.only(
                              top: 8,
                              bottom: 8,
                              left: 10,
                              right: 10,
                            ),
                            child: Text(
                              "Save",
                              style: TextStyle(
                                color: Colors.white,
                                fontSize: 15,
                                decoration: TextDecoration.none,
                                fontWeight: FontWeight.normal,
                              ),
                            ),
                          ),
                        ),
                      ),
                    ],
                  ),
                ),
              )
            ],
          ),
        ),
      ),
    );
  }
}
