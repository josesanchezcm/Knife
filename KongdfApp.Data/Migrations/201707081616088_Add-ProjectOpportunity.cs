namespace KongdfApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProjectOpportunity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Colleagues", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Colleagues", "CreatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Colleagues", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Colleagues", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Resumes", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Resumes", "CreatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Resumes", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Resumes", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Companies", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Companies", "CreatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Companies", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Companies", "UpdatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.Colleagues", "Name", c => c.String());
            AlterColumn("dbo.Colleagues", "Email", c => c.String());
            AlterColumn("dbo.Colleagues", "Telephone", c => c.String());
            AlterColumn("dbo.Colleagues", "MobilePhone", c => c.String());
            AlterColumn("dbo.Colleagues", "Address", c => c.String());
            AlterColumn("dbo.Colleagues", "Description", c => c.String());
            AlterColumn("dbo.Resumes", "AbstractIntroduction", c => c.String());
            AlterColumn("dbo.Resumes", "SpecialSkills", c => c.String());
            AlterColumn("dbo.Resumes", "WorkExperiences", c => c.String());
            AlterColumn("dbo.Companies", "Name", c => c.String());
            AlterColumn("dbo.Companies", "Email", c => c.String());
            AlterColumn("dbo.Companies", "Telephone", c => c.String());
            AlterColumn("dbo.Companies", "OfficialWebsite", c => c.String());
            AlterColumn("dbo.Companies", "Description", c => c.String());
            DropColumn("dbo.Colleagues", "Created");
            DropColumn("dbo.Colleagues", "Updated");
            DropColumn("dbo.Resumes", "Created");
            DropColumn("dbo.Resumes", "Updated");
            DropColumn("dbo.Companies", "Created");
            DropColumn("dbo.Companies", "Updated");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Companies", "Updated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Companies", "Created", c => c.DateTime(nullable: false));
            AddColumn("dbo.Resumes", "Updated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Resumes", "Created", c => c.DateTime(nullable: false));
            AddColumn("dbo.Colleagues", "Updated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Colleagues", "Created", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Companies", "Description", c => c.String(maxLength: 250));
            AlterColumn("dbo.Companies", "OfficialWebsite", c => c.String(maxLength: 250));
            AlterColumn("dbo.Companies", "Telephone", c => c.String(maxLength: 150));
            AlterColumn("dbo.Companies", "Email", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Companies", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Resumes", "WorkExperiences", c => c.String(maxLength: 500));
            AlterColumn("dbo.Resumes", "SpecialSkills", c => c.String(maxLength: 250));
            AlterColumn("dbo.Resumes", "AbstractIntroduction", c => c.String(maxLength: 250));
            AlterColumn("dbo.Colleagues", "Description", c => c.String(maxLength: 250));
            AlterColumn("dbo.Colleagues", "Address", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Colleagues", "MobilePhone", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Colleagues", "Telephone", c => c.String(maxLength: 150));
            AlterColumn("dbo.Colleagues", "Email", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Colleagues", "Name", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Companies", "UpdatedBy");
            DropColumn("dbo.Companies", "UpdatedDate");
            DropColumn("dbo.Companies", "CreatedBy");
            DropColumn("dbo.Companies", "CreatedDate");
            DropColumn("dbo.Resumes", "UpdatedBy");
            DropColumn("dbo.Resumes", "UpdatedDate");
            DropColumn("dbo.Resumes", "CreatedBy");
            DropColumn("dbo.Resumes", "CreatedDate");
            DropColumn("dbo.Colleagues", "UpdatedBy");
            DropColumn("dbo.Colleagues", "UpdatedDate");
            DropColumn("dbo.Colleagues", "CreatedBy");
            DropColumn("dbo.Colleagues", "CreatedDate");
        }
    }
}
