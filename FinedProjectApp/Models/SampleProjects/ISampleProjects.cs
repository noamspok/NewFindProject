using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinedProjectApp.Models
{
   public interface ISampleProjects
    {
        void Initilize();
        List<SampleProject> Samples { get; set; }
    }
}
