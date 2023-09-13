using Domain.Entities.Common;

namespace Domain.Entities
{
    //public class TransportRequest : BaseEntity
    //{
    //    public Guid UserId { get; set; }
    //    public User User { get; set; }
    //    public Guid CompanyId { get; set; }
    //    public Company TransportCompany { get; set; }
    //    public string RequestType { get; set; }
    //    public string Statement { get; set; }
    //    public bool ApprovalStatus { get; set; }
    //    public DateTime StartingDate { get; set; }
    //    public DateTime FinishingDate { get; set;}


    //    public TransportRequest()
    //    {
            
    //    }
    //    public TransportRequest(User user, string type, string statement, DateTime start, DateTime finish)
    //    {
    //        UserId = user.Id;
    //        User = user;

    //        RequestType = type;
    //        Statement = statement;
    //        ApprovalStatus = false;

    //        StartingDate = start;
    //        FinishingDate = finish;
    //    }


    //    public void AddCevap() { }


    //    public void SelectCevap(int cevapId) {
    //        if (ApprovalStatus)
    //            throw new Exception("Teklif zaten onaylanmış durumda");



    //        //foreach(Cevap c in Cevaplar)
    //        //{
    //        //  if(c.CevapId == cevapId)
    //        //  {
    //        //      Cevap.IsSelected = true;
    //        //      ApprovalStatus = true;
    //        //  }
    //        //}

    //        if (!ApprovalStatus)
    //            throw new Exception("Belirtilen Cevap Bulunamadı");

    //    }


    //    public void Complete() { }//team complete

    //    public void UserCompleteApproval() { }
    //}
}
