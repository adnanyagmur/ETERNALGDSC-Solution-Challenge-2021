import 'package:flutter/material.dart';
import 'Firebase.dart';

class Announcement extends StatefulWidget {
  @override
  _AnnouncementState createState() => _AnnouncementState();
}

class _AnnouncementState extends State<Announcement> {
  List<Posts> postList = [];
  @override
  void initState() {
    super.initState();
    fireBase database = new fireBase();
    database.retiveData(postList);
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Announcement'),
        backgroundColor: Colors.red,
        elevation: 4.4,
      ),
      body: postList.length == 0
          ? ListView(
              children: [
                Column(
                  children: [
                    Padding(
                      padding: const EdgeInsets.all(0),
                      child: Card(
                        shape: RoundedRectangleBorder(
                            borderRadius: BorderRadius.circular(15)),
                        elevation: 10.0,
                        margin: EdgeInsets.all(15.0),
                        child: Container(
                          padding: EdgeInsets.all(14),
                          child: Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            children: <Widget>[
                              Row(
                                mainAxisAlignment:
                                    MainAxisAlignment.spaceBetween,
                                children: <Widget>[
                                  Text(
                                    "16:30",
                                    style:
                                        Theme.of(context).textTheme.subtitle1,
                                    textAlign: TextAlign.center,
                                  ),
                                  Text(
                                    "11.02.2021",
                                    style:
                                        Theme.of(context).textTheme.subtitle1,
                                    textAlign: TextAlign.center,
                                  ),
                                ],
                              ),
                              Text(
                                "Taksim İlk Yardım Hastanesi",
                                style: Theme.of(context).textTheme.subtitle1,
                                textAlign: TextAlign.center,
                              ),
                              SizedBox(
                                height: 10.0,
                              ),
                              Text(
                                "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                                style: Theme.of(context).textTheme.subhead,
                                textAlign: TextAlign.center,
                              ),
                            ],
                          ),
                        ),
                      ),
                    ),
                    Padding(
                      padding: const EdgeInsets.all(0),
                      child: Card(
                        shape: RoundedRectangleBorder(
                            borderRadius: BorderRadius.circular(15)),
                        elevation: 10.0,
                        margin: EdgeInsets.all(15.0),
                        child: Container(
                          padding: EdgeInsets.all(14),
                          child: Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            children: <Widget>[
                              Row(
                                mainAxisAlignment:
                                    MainAxisAlignment.spaceBetween,
                                children: <Widget>[
                                  Text(
                                    "16:30",
                                    style:
                                        Theme.of(context).textTheme.subtitle1,
                                    textAlign: TextAlign.center,
                                  ),
                                  Text(
                                    "11.02.2021",
                                    style:
                                        Theme.of(context).textTheme.subtitle1,
                                    textAlign: TextAlign.center,
                                  ),
                                ],
                              ),
                              Text(
                                "Taksim İlk Yardım Hastanesi",
                                style: Theme.of(context).textTheme.subtitle1,
                                textAlign: TextAlign.center,
                              ),
                              SizedBox(
                                height: 10.0,
                              ),
                              Text(
                                "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                                style: Theme.of(context).textTheme.subhead,
                                textAlign: TextAlign.center,
                              ),
                            ],
                          ),
                        ),
                      ),
                    ),
                    Padding(
                      padding: const EdgeInsets.all(0),
                      child: Card(
                        shape: RoundedRectangleBorder(
                            borderRadius: BorderRadius.circular(15)),
                        elevation: 10.0,
                        margin: EdgeInsets.all(15.0),
                        child: Container(
                          padding: EdgeInsets.all(14),
                          child: Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            children: <Widget>[
                              Row(
                                mainAxisAlignment:
                                    MainAxisAlignment.spaceBetween,
                                children: <Widget>[
                                  Text(
                                    "16:30",
                                    style:
                                        Theme.of(context).textTheme.subtitle1,
                                    textAlign: TextAlign.center,
                                  ),
                                  Text(
                                    "11.02.2021",
                                    style:
                                        Theme.of(context).textTheme.subtitle1,
                                    textAlign: TextAlign.center,
                                  ),
                                ],
                              ),
                              Text(
                                "Taksim İlk Yardım Hastanesi",
                                style: Theme.of(context).textTheme.subtitle1,
                                textAlign: TextAlign.center,
                              ),
                              SizedBox(
                                height: 10.0,
                              ),
                              Text(
                                "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                                style: Theme.of(context).textTheme.subhead,
                                textAlign: TextAlign.center,
                              ),
                            ],
                          ),
                        ),
                      ),
                    ),
                    Padding(
                      padding: const EdgeInsets.all(0),
                      child: Card(
                        shape: RoundedRectangleBorder(
                            borderRadius: BorderRadius.circular(15)),
                        elevation: 10.0,
                        margin: EdgeInsets.all(15.0),
                        child: Container(
                          padding: EdgeInsets.all(14),
                          child: Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            children: <Widget>[
                              Row(
                                mainAxisAlignment:
                                    MainAxisAlignment.spaceBetween,
                                children: <Widget>[
                                  Text(
                                    "16:30",
                                    style:
                                        Theme.of(context).textTheme.subtitle1,
                                    textAlign: TextAlign.center,
                                  ),
                                  Text(
                                    "11.02.2021",
                                    style:
                                        Theme.of(context).textTheme.subtitle1,
                                    textAlign: TextAlign.center,
                                  ),
                                ],
                              ),
                              Text(
                                "Taksim İlk Yardım Hastanesi",
                                style: Theme.of(context).textTheme.subtitle1,
                                textAlign: TextAlign.center,
                              ),
                              SizedBox(
                                height: 10.0,
                              ),
                              Text(
                                "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                                style: Theme.of(context).textTheme.subhead,
                                textAlign: TextAlign.center,
                              ),
                            ],
                          ),
                        ),
                      ),
                    ),
                  ],
                ),
              ],
            )
          : ListView.builder(
              itemCount: postList.length,
              itemBuilder: (_, index) {
                return PostUI(
                    postList[index].hospital,
                    postList[index].description,
                    postList[index].date,
                    postList[index].time,
                    context);
              }),
    );
  }
}

class Posts {
  var hospital, description, date, time;
  Posts(this.hospital, this.date, this.description, this.time);
}

Widget PostUI(
    var hospital, var description, var date, var time, BuildContext context) {
  return Card(
    shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(15)),
    elevation: 10.0,
    margin: EdgeInsets.all(15.0),
    child: Container(
      padding: EdgeInsets.all(14),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: <Widget>[
          Row(
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            children: <Widget>[
              Text(
                time,
                style: Theme.of(context).textTheme.subtitle1,
                textAlign: TextAlign.center,
              ),
              Text(
                date,
                style: Theme.of(context).textTheme.subtitle1,
                textAlign: TextAlign.center,
              ),
            ],
          ),
          Text(
            hospital,
            style: Theme.of(context).textTheme.subtitle1,
            textAlign: TextAlign.center,
          ),
          SizedBox(
            height: 10.0,
          ),
          Text(
            description,
            style: Theme.of(context).textTheme.subhead,
            textAlign: TextAlign.center,
          ),
        ],
      ),
    ),
  );
}
