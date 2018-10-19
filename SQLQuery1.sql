INSERT INTO Directors(UserName, Password, E_mail) VALUES('a', 'b', 'a@com') 
INSERT INTO Projects(ProjectName,ProjectPath,Research,GroupSize_2,DirectorName,Average) VALUES('d','a',1,1,'a',45)
UPDATE Projects
SET Average = 55
WHERE ProjectName='a';
INSERT INTO ProjectLang(ProjectName,C_Sharp,HTML,Python,JS) VALUES('c',3,2,1,4)
INSERT INTO ProjectLang(ProjectName,C,Java,Python,JS) VALUES('a',3,2,1,4)
INSERT INTO ProjectKind(ProjectName,Machine,AI) VALUES('a',1,1)
INSERT INTO ProjectKind(ProjectName,Web,Cyber) VALUES('c',1,1)

select * from Projects a
where a.GroupSize_2>0 and a.Research>0 or a.Industry>0 
and a.ProjectName in (select ProjectName from ProjectLang b where  b.C_Sharp>0 or b.Java>0)
and a.ProjectName in (select ProjectName from ProjectKind c where c.Web>0 or c.Machine>0)

select * from projects where ProjectName = @userName

select DirectorsCourses.*, Projects.Average from projects
 inner JOIN DirectorsCourses ON projects.ProjectName = 'a' and DirectorsCourses.ProjectName='a' 

 INSERT INTO [dbo].[DirectorsCourses] ([ProjectName], [CompSite], [DistributedSystems], [DesidnTemp], [Multimedia]) VALUES ('c', 1, 1, 1,1 )
, [AdvSQL], [DataManage], [GraphesTheory], [CompSite], [DistributedSystems], [DesidnTemp], [Multimedia], [Crypto], [IntroInteligence], [Robotics], [Bioligic], [Decision], [Safe], [Networks], [Dinalogs], [Pic], [SwVal], [SQL], [GamesIntro], [NatLang], [Grafic], [RoboAlgos], [DeapLearning]
