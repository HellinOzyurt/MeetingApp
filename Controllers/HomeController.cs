using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;

namespace MeetingApp.Controllers{

    public class HomeController: Controller{

public IActionResult Index(){

    int saat = DateTime.Now.Hour;

ViewData["Selamlama"] = saat > 12 ? "İyi Günler" : "Günaydınlar";
int userCount = Repository.Users.Where(i => i.WillAttend == true).Count();
// ViewData["KullaniciAdi"]= "Hellin";

var meetingInfo = new MeetingInfo(){
    Id = 1,
    Location = "Ankara, Kültür Merkezi",
    Date = new DateTime(2025, 05, 06,20,0,0),
    NumberOfPeople = userCount
};

return View(meetingInfo);
}
    }
}