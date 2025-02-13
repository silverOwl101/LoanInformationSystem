using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanInformationSystemMVPLibrary.Model;
using LoanInformationSystemMVPLibrary.Repository;

namespace LoanInformationSystemMVPLibrary.Service
{
    public class PostingService
    {
        private PostingRepo _postingRepo;
        private List<GetPostingInfo> storeList = new List<GetPostingInfo>();
        public List<GetPostingInfo> OnSetGetPostingList(Customer customerId)
        {
            _postingRepo = new PostingRepo();
            storeList = _postingRepo.GetPostingList(customerId);
            return storeList;
        }        
    }
}
