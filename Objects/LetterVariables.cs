namespace FriendLetter.Objects
{
  public class LetterVariables
  {
    private string _recipient;
    private string _sender;
    private string _vacation;
    private string _item;


    public string GetRecipient()
    {
      return _recipient;
    }

    public void SetRecipient(string newRecipient)
    {
      _recipient = newRecipient;
    }

    public string GetSender()
    {
      return _sender;
    }

    public void SetSender(string newSender)
    {
      _sender = newSender;
    }

    public string GetVacation()
    {
      return _vacation;
    }

    public void SetVacation(string newVacation)
    {
      _vacation = newVacation;
    }

    public string GetItem()
    {
      return _item;
    }

    public void SetItem(string newItem)
    {
      _item = newItem;
    }

  }
}
