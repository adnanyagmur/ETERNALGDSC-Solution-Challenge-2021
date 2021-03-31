import 'package:firebase_auth/firebase_auth.dart';
import 'package:firebase_core/firebase_core.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter/painting.dart';
import 'package:flutter_application_1/PassresetScreen.dart';
import 'package:flutter_application_1/registerPage.dart';
import 'package:fluttertoast/fluttertoast.dart';
import 'Firebase.dart';
import 'Index.dart';
import 'registerPage.dart';

class Login extends StatefulWidget {
  @override
  _LoginState createState() => _LoginState();
}

class _LoginState extends State<Login> {
  final emailController = TextEditingController();
  final passwordController = TextEditingController();
  String _email, _password;
  var _TextFormFieldKey = GlobalKey();

  fireBase database = new fireBase();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Center(
        child: SingleChildScrollView(
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
                        Padding(
                          padding: EdgeInsets.only(
                              top: 10, bottom: 15, left: 10, right: 10),
                          child: Image(
                            image: AssetImage('assets/images/icon.png'),
                          ),
                        ),
                        //Bunu eklemekten emin değilim
                        /*Padding(
                        padding: EdgeInsets.all(10),
                        child: Align(
                          alignment: Alignment
                              .centerLeft, // Align however you like (i.e .centerRight, centerLeft)
                          child: Text(
                            "Welcome ",
                            style: TextStyle(
                              fontSize: 22.5,
                              color: Colors.black,
                              fontWeight:FontWeight.bold,
                            ),
                          ),
                        ),
                      ),*/
                        TextFormField(
                          controller: emailController,
                          onChanged: (value) {
                            _email = emailController.text;
                          },
                          style: TextStyle(color: Color(0xFF000000)),
                          cursorColor: Color(0xF9b9b9b),
                          keyboardType: TextInputType.text,
                          decoration: InputDecoration(
                            prefixIcon: Icon(
                              Icons.email,
                              color: Colors.grey,
                            ),
                            hintText: "E-mail",
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
                            _password = passwordController.text;
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
                            hintText: "Password",
                            hintStyle: TextStyle(
                              color: Color(0xFF9b9b9b),
                              fontSize: 15,
                              fontWeight: FontWeight.normal,
                            ),
                          ),
                        ),
                        Padding(
                          padding: EdgeInsets.all(0),
                          child: FlatButton(
                            child: Align(
                              alignment: Alignment.topLeft,
                              child: Text(
                                "Forgot Password ?",
                                style: TextStyle(
                                    color: Colors.blue, fontSize: 12.5),
                              ),
                            ),
                            onPressed: () {
                              Navigator.push(
                                context,
                                MaterialPageRoute(
                                    builder: (context) => RePassword()),
                              );
                            },
                            padding: EdgeInsets.all(20),
                            textColor: Colors.black,
                          ),
                        ),
                        Padding(
                          padding: const EdgeInsets.only(
                            top: 10,
                            left: 10,
                            right: 10,
                          ),
                          child: RaisedButton(
                            color: Colors.red[400],
                            shape: new RoundedRectangleBorder(
                                borderRadius: new BorderRadius.circular(10)),

                            //Giriş kısmı buradan gerçekleştirilecek..
                            onPressed: () async {
                              var giris =
                                  database.login(_email, _password, context);
                            },
                            child: Padding(
                              padding: EdgeInsets.only(
                                top: 9,
                                bottom: 9,
                                left: 18,
                                right: 18,
                              ),
                              child: Text(
                                "Login",
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
                        Padding(
                          padding: const EdgeInsets.all(10),
                          child: RaisedButton(
                            color: Colors.red[400],
                            shape: new RoundedRectangleBorder(
                                borderRadius: new BorderRadius.circular(10)),

                            //Kayıt oluşturulacak
                            onPressed: () async {
                              Navigator.push(
                                context,
                                MaterialPageRoute(
                                    builder: (context) => Register()),
                              );
                            },
                            child: Padding(
                              padding: EdgeInsets.only(
                                top: 8,
                                bottom: 8,
                                left: 10,
                                right: 10,
                              ),
                              child: Text(
                                "Register",
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
      ),
    );
  }
}

class Wiget {}
