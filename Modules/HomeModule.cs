using Nancy;
using FriendLetter.Objects;

namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/greeting_card"] = _ => {
        LetterVariables myLetterVariables = new LetterVariables();
        myLetterVariables.SetRecipient(Request.Query["recipient"]);
        myLetterVariables.SetSender(Request.Query["sender"]);
        myLetterVariables.SetVacation(Request.Query["vacation"]);
        myLetterVariables.SetItem(Request.Query["item"]);
        return View["hello.cshtml", myLetterVariables];
      };
      Get["/favorite_photos"] = _ => View["favorite_photos.html"];
      Get["/form"] = _ => {
        return View["form.cshtml"];
      };
    }
  }
}
