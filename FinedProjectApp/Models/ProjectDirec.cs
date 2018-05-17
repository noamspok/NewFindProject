using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProjectDir
/// </summary>
public class ProjectDirec
{
    /*
         * Project Director personal details
         */
    //Project Director profile nickname.
    [Key]
    public string UserName { get; set; }
    
    //Project Director password
    [Required]
    public string Password { get; set; }

    [Required]
    public string Email { get; set; }
    //Project Director first name
    
    
    /*
     * Project Director professional information
     */


    //Locations where Project Director is available for meating.
    [Required]
    public string Location { get; set; }

    //Project Director preference in fild of project: industry/ reserch 
    [Required]
    public string FieldOfProject { get; set; }

    

    

    //programming languages that Project Director demands 
    [Required]
    public string ProgrammingLanguage { get; set; }

    //Kind Of Project AI, machine learning, etc..
    [Required]
    public string KindOfProject { get; set; }

    

    // attached file which describes the project
    public string ProjectDescriptionFile { get; set; }



}