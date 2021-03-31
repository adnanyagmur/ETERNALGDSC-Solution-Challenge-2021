import 'package:firebase_core/firebase_core.dart';
import 'package:flutter/material.dart';
import 'Firebase.dart';

class RePassword extends StatefulWidget {
  @override
  _RePasswordState createState() => _RePasswordState();
}

class _RePasswordState extends State<RePassword> {
  final emailController = TextEditingController();
  fireBase database =new fireBase();
  @override
  Widget build(BuildContext context) {
     var _email;
    return Scaffold(
      appBar: AppBar(
        title: Text('Reset Password'),
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
                      
                     Padding(
                        padding: EdgeInsets.all(10),
                        child: Align(
                          alignment: Alignment
                              .centerLeft, // Align however you like (i.e .centerRight, centerLeft)
                          child: Text(
                            "Enter your e-mail ",
                            style: TextStyle(
                              fontSize: 20,
                              color: Colors.black,
                              fontWeight:FontWeight.w400,
                            ),
                          ),
                        ),
                      ),

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
                            database.resetPassword(_email,context);
                          },
                          child: Padding(
                            padding: EdgeInsets.only(
                              top: 9,
                              bottom: 9,
                              left: 18,
                              right: 18,
                            ),
                            child: Text(
                              "Send Email",
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
