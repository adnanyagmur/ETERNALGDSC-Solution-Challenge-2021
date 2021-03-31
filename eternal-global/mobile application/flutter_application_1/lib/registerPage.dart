import 'package:flutter/material.dart';
import 'package:flutter_application_1/size_config.dart';
import 'Firebase.dart';

class Register extends StatefulWidget {
  @override
  _RegisterState createState() => _RegisterState();
}

class _RegisterState extends State<Register> {
  final emailController = TextEditingController();
  final passwordController = TextEditingController();
  String _email, _password;
  var _TextFormFieldKey = GlobalKey();
 fireBase database = new fireBase();
  @override
  Widget build(BuildContext context) {
   
    var _email,_password; //20
    return Scaffold(
     appBar: AppBar(
        title: Text('Registration'),
        backgroundColor: Colors.red,
        elevation: 4.4,
        ),
      
      body:Container(
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
                        padding: const EdgeInsets.all(10),
                        child: RaisedButton(
                          color: Colors.red[400],
                          shape: new RoundedRectangleBorder(
                              borderRadius: new BorderRadius.circular(10)),

                          //Giriş kısmı buradan gerçekleştirilecek..
                          onPressed: () async {
                            var kayit = database.register(_email, _password,context);
                          
                          },
                          child: Padding(
                            padding: EdgeInsets.only(
                              top: 8,
                              bottom: 8,
                              left: 10,
                              right: 10,
                            ),
                            child: Text(
                              "sign up",
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
