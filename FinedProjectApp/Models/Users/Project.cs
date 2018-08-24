using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProjectDir
/// </summary>
namespace FinedProjectApp.Models
{
	public class Project
	{
		/*
			 * Project Director personal details
			 */
		//Project Director profile nickname.
		[Key]
		public string UserName { get; set; }

		


		/*
		 * Project Director professional information
		 */


		
		//Project Director preference in fild of project: industry/ reserch 
		[Required]
		public string FieldOfProject { get; set; }

		//student elective courses
		[Required]
		public string Courses { get; set; }



		//programming languages that Project Director demands 
		[Required]
		public string ProgrammingLanguage { get; set; }

		//Kind Of Project AI, machine learning, etc..
		[Required]
		public string KindOfProject { get; set; }

		//Director's preference in size of group to do the project
		[Required]
		public string GroupSize { get; set; }

		// attached file which describes the project
		[Required]
		public string ProjectName { get; set; }

		// attached file which describes the project
		[Required]
		public string ProjectDescriptionFile { get; set; }



	}
}