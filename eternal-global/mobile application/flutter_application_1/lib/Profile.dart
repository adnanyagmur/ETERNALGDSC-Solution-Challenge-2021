import 'package:flutter/material.dart';
import 'constants.dart';
import 'body.dart';
import 'size_config.dart';

class ProfileScreen extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    SizeConfig().init(context);
    return Scaffold(
       appBar: AppBar(
        title: Text('Profile'),
        backgroundColor: Colors.red,
        elevation: 4.4,
       ),
      body: Body(),
     
    );
  }

  
}