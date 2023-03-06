using SharedLibraries_Plugins.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharedLibraries_Plugins.Repos.BookOfFeedback
{
    public class BookOfFeedbackRepos : IBookOfFeedbackRepos
    {
        private CrmContext crmContext;

        public BookOfFeedbackRepos(CrmContext _crmContext)
        {
            this.crmContext = _crmContext;
        }

        public void createBoF(rbtt_bookoffeedback bof)
        {
            crmContext.AddObject(bof);
            crmContext.SaveChanges();
        }

        public rbtt_bookoffeedback retrieveBoFById(Guid bofId)
        {
            rbtt_bookoffeedback bof = (from a in crmContext.rbtt_bookoffeedbackSet
                                       where a.Id == bofId
                                       select new rbtt_bookoffeedback
                                       {
                                           Id = a.Id,
                                           CreatedBy = a.CreatedBy,
                                           ModifiedBy = a.ModifiedBy
                                       }).FirstOrDefault();
            return bof;
        }

        public List<rbtt_bookoffeedback> retrieveMultipleBoFs()
        {
            List<rbtt_bookoffeedback> bofList = (from a in crmContext.rbtt_bookoffeedbackSet
                                                 select new rbtt_bookoffeedback
                                                 {
                                                     Id = a.Id,
                                                     rbtt_Anonimous = a.rbtt_Anonimous,
                                                     rbtt_Category = a.rbtt_Category,
                                                     rbtt_Comment = a.rbtt_Comment,
                                                     rbtt_Country = a.rbtt_Country,
                                                     rbtt_name = a.rbtt_name,
                                                     rbtt_Rating = a.rbtt_Rating,
                                                     CreatedBy = a.CreatedBy,
                                                     ModifiedBy = a.ModifiedBy
                                                 }).ToList();
            return bofList;
        }

        public void updateBoF(rbtt_bookoffeedback bof)
        {
            if (!crmContext.IsAttached(bof))
            {
                crmContext.Attach(bof);
            }
            crmContext.UpdateObject(bof);
            crmContext.SaveChanges();
        }
    }
}
