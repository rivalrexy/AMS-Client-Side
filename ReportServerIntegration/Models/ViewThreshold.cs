using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReportServerIntegration.Models
{
    public class ViewThreshold
    {

        public List<METRIC_THRESHOLD> allMetricThreshold { get; set; }

        public List<ACTIVE_THRESHOLD> allActiveThreshold { get; set; }

    }
}