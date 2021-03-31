import 'package:firebase_auth/firebase_auth.dart';
import 'package:firebase_core/firebase_core.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter_application_1/registerPage.dart';
import 'package:flutter_application_1/size_config.dart';
import 'package:fluttertoast/fluttertoast.dart';
import 'Firebase.dart';
import 'Index.dart';
import 'registerPage.dart';

class ChangePassword extends StatefulWidget {
  @override
  _ChangePasswordState createState() => _ChangePasswordState();
}

class _ChangePasswordState extends State<ChangePassword> {
  final emailController = TextEditingController();
  final passwordController = TextEditingController();
  String _currentPass, _passwordNew;
  var _TextFormFieldKey = GlobalKey();

  fireBase database = new fireBase();

  @override
  Widget build(BuildContext context) {
     SizeConfig().init(context);
    return Scaffold(
      appBar:AppBar(
       
        title: Text('Healthy Duty'),
        backgroundColor: Colors.red,
        elevation: 4.4,
      ),

      body: Container(
        child: Padding(
          padding: const EdgeInsets.all(8.0),
          child: Column(
            mainAxisAlignment: MainAxisAlignment.center,
            children: <Widget>[
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
                        controller: emailController,
                        onChanged: (value) {
                          _currentPass = emailController.text;
                        },
                        style: TextStyle(color: Color(0xFF000000)),
                        cursorColor: Color(0xF9b9b9b),
                        keyboardType: TextInputType.text,
                        obscureText: true,
                        decoration: InputDecoration(
                          prefixIcon: Icon(
                            Icons.lock,
                            color: Colors.grey,
                          ),
                          hintText: "Current Password",
                          hintStyle: TextStyle(
                            color: Color(0xFF9b9b9b),
                            fontSize: 15,
                            fontWeight: FontWeight.normal,
                          ),
                        ),
                      ),
                      TextFormField(
                        controller: passwordController,
                        onChanged: (value) {
                          _passwordNew = passwordController.text;
                        },
                        style: TextStyle(color: Color(0xFF000000)),
                        cursorColor: Color(0xF9b9b9b),
                        keyboardType: TextInputType.text,
                        obscureText: true,
                        decoration: InputDecoration(
                          prefixIcon: Icon(
                            Icons.lock,
                            color: Colors.grey,
                          ),
                          hintText: "New Password",
                          hintStyle: TextStyle(
                            color: Color(0xFF9b9b9b),
                            fontSize: 15,
                            fontWeight: FontWeight.normal,
                          ),
                        ),
                      ),
                        
                      Padding(
                        padding: const EdgeInsets.all(10),
                        child: RaisedButton(
                          color: Colors.red[400],
                          shape: new RoundedRectangleBorder(
                              borderRadius: new BorderRadius.circular(10)),

                          //Giriş kısmı buradan gerçekleştirilecek..
                          onPressed: () async {
                            var Change = database.changePassword(_currentPass,_passwordNew,context);
                          
                          },
                          child: Padding(
                            padding: EdgeInsets.only(
                              top: 8,
                              bottom: 8,
                              left: 10,
                              right: 10,
                            ),
                            child: Text(
                              "Change Password",
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
