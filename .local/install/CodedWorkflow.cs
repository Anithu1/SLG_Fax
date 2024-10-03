using UiPath.CodedWorkflows;
using UiPath.Mail.Activities.Api;

namespace SLG_Fax
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        public CodedWorkflow()
        {
            _ = new System.Type[]{typeof(UiPath.Mail.Activities.Api.IMailService)};
        }

        protected UiPath.Mail.Activities.Api.IMailService mail { get => serviceContainer.Resolve<UiPath.Mail.Activities.Api.IMailService>() ; }
    }
}