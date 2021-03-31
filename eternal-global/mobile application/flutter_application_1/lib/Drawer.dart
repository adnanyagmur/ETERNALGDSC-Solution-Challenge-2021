import 'package:firebase_core/firebase_core.dart';
import 'package:flutter/material.dart';
import 'package:flutter_application_1/Announcement.dart';
import 'package:flutter_application_1/DonateScreen.dart';
import 'Firebase.dart';
import 'Index.dart';
import'login_Page.dart';
import 'Profile.dart';


class myDrawer extends StatefulWidget{
  @override
  State<StatefulWidget> createState() =>_myDraverState();
  
  
}

class _myDraverState extends State {

   fireBase database = new fireBase();
   
     @override
  Widget build(BuildContext context) {
    return Drawer(
      child: ListView(children: <Widget>[
        DrawerHeader(
          child:Align
          (child:Column(
            mainAxisAlignment:MainAxisAlignment.center,
            children:<Widget> [
              Icon(Icons.healing,color: Colors.white,size: 100.0,),
              Text("Healthy Duty",style: TextStyle(color: Colors.white,fontSize: 25.0),)
            ],
            ),
            ) ,
            decoration: BoxDecoration(color:Colors.red),
             
           ),
            ListTile(
            leading: Icon(Icons.home),
            title: Text('Index'),
            trailing: Icon(Icons.arrow_right),
            onTap: () {
               Navigator.push(context,MaterialPageRoute(builder:(context) =>Anasayfa()),);
            },
          ), ListTile(
            leading: Icon(Icons.person),
            title: Text('Profile'),
            trailing: Icon(Icons.arrow_right),
            onTap: () {
              Navigator.push(context,MaterialPageRoute(builder:(context) =>ProfileScreen()),);
            },
          ), ListTile(
            leading: Icon(Icons.local_hospital),
            title: Text('Favorite Hospital'),
            trailing: Icon(Icons.arrow_right),
            onTap: () {
              Navigator.push(context,MaterialPageRoute(builder:(context) =>Anasayfa()),);
            },
          ),
          ListTile(
            leading: Icon(Icons.announcement),
            title: Text('announcement'),
            trailing: Icon(Icons.arrow_right),
            onTap: () {
             Navigator.push(context,MaterialPageRoute(builder:(context) =>Announcement()),);
            },
          ),
          ListTile(
            leading: Icon(Icons.chat),
            title: Text('Chat'),
            trailing: Icon(Icons.arrow_right),
            onTap: () {
             Navigator.push(context,MaterialPageRoute(builder:(context) =>Anasayfa()),);
            },
          ),ListTile(
            leading: Icon(Icons.card_giftcard),
            title: Text('Donate!'),
            trailing: Icon(Icons.arrow_right),
            onTap: () {
             Navigator.push(context,MaterialPageRoute(builder:(context) =>Donate()),);
            },
          ),ListTile(
            leading: Icon(Icons.exit_to_app),
            title: Text('Sign Out'),
            trailing: Icon(Icons.arrow_right),
            onTap: () {
              database.exit(context);
            },
          ),


           ],


      ),
      );
  }

}