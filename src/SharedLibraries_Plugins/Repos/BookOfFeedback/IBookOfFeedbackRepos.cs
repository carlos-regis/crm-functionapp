using SharedLibraries_Plugins.EntityModel;
using System;
using System.Collections.Generic;

namespace SharedLibraries_Plugins.Repos.BookOfFeedback
{
    public interface IBookOfFeedbackRepos
    {
        rbtt_bookoffeedback retrieveBoFById(Guid bofId);
        List<rbtt_bookoffeedback> retrieveMultipleBoFs();
        void createBoF(rbtt_bookoffeedback bof);
        void updateBoF(rbtt_bookoffeedback bof);
    }
}
