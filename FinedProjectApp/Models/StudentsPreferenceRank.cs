using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinedProjectApp.Models
{
    public class StudentsPreferenceRank
    {
        string StudentsUserName;
        private Samples samples;
        private List<int> rank;
        public StudentsPreferenceRank(string userName,Samples samples)
        {
            this.StudentsUserName = userName;
            this.samples = samples;
            this.rank = new List<int>();
        }

        //this function ranks the sample projects acording to the students perforence.
        public void RankProjectSamples()
        {
            int score = 0;
            foreach (SampleProject s in samples.getSamples())
            {
                score += getKinedScore(s.Kined);

            }

        }

        private int getKinedScore(string kined)
        {
            
            return 0;
        }
        private int getLanguageScore()
        {
            return 0;
        }
        private int getFieldScore()
        {
            return 0;
        }
        private int getGroupSizeScore()
        {
            return 0;
        } 
}