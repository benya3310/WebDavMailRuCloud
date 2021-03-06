using System.Collections.Generic;
using System.Threading.Tasks;

namespace YaR.MailRuCloud.Api.SpecialCommands
{
    public class RemoveBadLinksCommand : SpecialCommand
    {
        public RemoveBadLinksCommand(MailRuCloud cloud, string path, IList<string> parames): base(cloud, path, parames)
        {
        }

        protected override MinMax<int> MinMaxParamsCount { get; } = new MinMax<int>(0);

        public override Task<SpecialCommandResult> Execute()
        {
            Cloud.RemoveDeadLinks();
            return Task.FromResult(SpecialCommandResult.Success);
        }
    }
}