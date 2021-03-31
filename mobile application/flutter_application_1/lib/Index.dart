import 'package:flutter/material.dart';
import 'package:flutter_application_1/Drawer.dart';
import 'package:flutter_application_1/size_config.dart';
import 'package:fluttertoast/fluttertoast.dart';
import 'package:google_maps_flutter/google_maps_flutter.dart';

class Anasayfa extends StatelessWidget {
  const Anasayfa({Key key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    SizeConfig().init(context);
    return Scaffold(
      appBar: AppBar(
        title: Text('Nearby Hospitals'),
        backgroundColor: Colors.red,
        elevation: 4.4,
      ),
      drawer: myDrawer(),
      backgroundColor: Colors.white,
      body: GoogleMap(
        initialCameraPosition: CameraPosition(
            target: LatLng(41.07570640144488, 28.924175367376108), zoom: 10),
      ),
    );
  }
}
