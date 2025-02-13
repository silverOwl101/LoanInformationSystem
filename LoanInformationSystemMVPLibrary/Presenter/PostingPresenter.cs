using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanInformationSystemMVPLibrary.Model;
using LoanInformationSystemMVPLibrary.Service;
using LoanInformationSystemMVPLibrary.View;

namespace LoanInformationSystemMVPLibrary.Presenter
{    
    public class PostingPresenter
    {
        private IPosting _posting;
        private PostingService postingService;
        private Customer customer = new Customer();

        public PostingPresenter(IPosting posting)
        {
            _posting = posting;
        }
        public List<GetPostingInfo> OnLoadGetPostingList()
        {            
            customer.Id = _posting.CustomerId;
            postingService = new PostingService();
            return postingService.OnSetGetPostingList(customer);
        }
    }
}
