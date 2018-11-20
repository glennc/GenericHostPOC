
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace SampleApplications
{
        public class WorkItemProcessing
        {
        private IWorkItemProcessor _workItemProcessor;
        
        public WorkItemProcessing(IWorkItemProcessor workItemProcessor)
        {
            _workItemProcessor = workItemProcessor;
        }
        
        public void ProcessWorkItem([QueueTrigger("test")] WorkItem workItem, ILogger logger)
        {
            _workItemProcessor.ProcessItem(workItem);
            logger.LogInformation($"Processed work item {workItem.ID}");
        }
    }
}