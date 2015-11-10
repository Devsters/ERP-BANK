namespace Bank_DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "account",
                c => new
                    {
                        id = c.Int(nullable: false),
                        accountType = c.String(maxLength: 255, storeType: "nvarchar"),
                        balance = c.Single(nullable: false),
                        opnedDate = c.String(maxLength: 255, storeType: "nvarchar"),
                        client_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("client", t => t.client_id)
                .Index(t => t.client_id);
            
            CreateTable(
                "client",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        birthDate = c.DateTime(nullable: false, precision: 0),
                        email = c.String(maxLength: 255, storeType: "nvarchar"),
                        lastName = c.String(maxLength: 255, storeType: "nvarchar"),
                        login = c.String(maxLength: 255, storeType: "nvarchar"),
                        name = c.String(maxLength: 255, storeType: "nvarchar"),
                        passWord = c.String(maxLength: 255, storeType: "nvarchar"),
                        phoneNumber = c.String(maxLength: 255, storeType: "nvarchar"),
                        registrationDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "draft",
                c => new
                    {
                        id = c.Int(nullable: false),
                        amount = c.Single(nullable: false),
                        date = c.String(maxLength: 255, storeType: "nvarchar"),
                        effect = c.Boolean(nullable: false),
                        pay_date = c.String(maxLength: 255, storeType: "nvarchar"),
                        rib = c.String(maxLength: 255, storeType: "nvarchar"),
                        time = c.String(maxLength: 255, storeType: "nvarchar"),
                        account_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("account", t => t.account_id)
                .Index(t => t.account_id);
            
            CreateTable(
                "transaction",
                c => new
                    {
                        id = c.Int(nullable: false),
                        amount = c.Single(nullable: false),
                        date = c.String(maxLength: 255, storeType: "nvarchar"),
                        effect = c.Boolean(nullable: false),
                        time = c.String(maxLength: 255, storeType: "nvarchar"),
                        account_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("account", t => t.account_id)
                .Index(t => t.account_id);
            
            CreateTable(
                "transfer",
                c => new
                    {
                        id = c.Int(nullable: false),
                        amount = c.Single(nullable: false),
                        bic = c.String(maxLength: 255, storeType: "nvarchar"),
                        date = c.DateTime(nullable: false, precision: 0),
                        effect = c.Boolean(nullable: false),
                        iban = c.String(maxLength: 255, storeType: "nvarchar"),
                        nameFull = c.String(maxLength: 255, storeType: "nvarchar"),
                        rib = c.String(maxLength: 255, storeType: "nvarchar"),
                        time = c.String(maxLength: 255, storeType: "nvarchar"),
                        account_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("account", t => t.account_id)
                .Index(t => t.account_id);
            
            CreateTable(
                "candidature",
                c => new
                    {
                        id = c.Int(nullable: false),
                        cv = c.String(maxLength: 255, storeType: "nvarchar"),
                        email = c.String(maxLength: 255, storeType: "nvarchar"),
                        lastName = c.String(maxLength: 255, storeType: "nvarchar"),
                        name = c.String(maxLength: 255, storeType: "nvarchar"),
                        role = c.String(maxLength: 255, storeType: "nvarchar"),
                        state = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "contract",
                c => new
                    {
                        id = c.Int(nullable: false),
                        contractType = c.String(maxLength: 255, storeType: "nvarchar"),
                        endDate = c.String(maxLength: 255, storeType: "nvarchar"),
                        startDate = c.String(maxLength: 255, storeType: "nvarchar"),
                        employee_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("employee", t => t.employee_id)
                .Index(t => t.employee_id);
            
            CreateTable(
                "employee",
                c => new
                    {
                        id = c.Int(nullable: false),
                        adress = c.String(maxLength: 255, storeType: "nvarchar"),
                        birthDate = c.String(maxLength: 255, storeType: "nvarchar"),
                        cin = c.Int(nullable: false),
                        civilState = c.String(maxLength: 255, storeType: "nvarchar"),
                        email = c.String(maxLength: 255, storeType: "nvarchar"),
                        kidsNumber = c.Int(nullable: false),
                        lastName = c.String(maxLength: 255, storeType: "nvarchar"),
                        name = c.String(maxLength: 255, storeType: "nvarchar"),
                        passWord = c.String(maxLength: 255, storeType: "nvarchar"),
                        phoneNumber = c.Int(nullable: false),
                        role = c.String(maxLength: 255, storeType: "nvarchar"),
                        userName = c.String(maxLength: 255, storeType: "nvarchar"),
                        local_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("local", t => t.local_id)
                .Index(t => t.local_id);
            
            CreateTable(
                "local",
                c => new
                    {
                        id = c.Int(nullable: false),
                        city = c.String(maxLength: 255, storeType: "nvarchar"),
                        region = c.String(maxLength: 255, storeType: "nvarchar"),
                        typeLocal = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "material",
                c => new
                    {
                        idMat = c.Int(nullable: false),
                        designation = c.String(maxLength: 255, storeType: "nvarchar"),
                        quantite = c.Int(nullable: false),
                        local_id = c.Int(),
                        supplier_id_supp = c.Int(),
                    })
                .PrimaryKey(t => t.idMat)
                .ForeignKey("local", t => t.local_id)
                .ForeignKey("supplier", t => t.supplier_id_supp)
                .Index(t => t.local_id)
                .Index(t => t.supplier_id_supp);
            
            CreateTable(
                "supplier",
                c => new
                    {
                        id_supp = c.Int(nullable: false),
                        adress = c.String(maxLength: 255, storeType: "nvarchar"),
                        email = c.String(maxLength: 255, storeType: "nvarchar"),
                        name = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id_supp);
            
            CreateTable(
                "payroll",
                c => new
                    {
                        id = c.Int(nullable: false),
                        addsAmount = c.Single(nullable: false),
                        endDate = c.String(maxLength: 255, storeType: "nvarchar"),
                        extraWorkedHours = c.Int(nullable: false),
                        startDate = c.String(maxLength: 255, storeType: "nvarchar"),
                        workedHours = c.Int(nullable: false),
                        employee_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("employee", t => t.employee_id)
                .Index(t => t.employee_id);
            
            CreateTable(
                "meeting",
                c => new
                    {
                        id = c.Int(nullable: false),
                        email = c.String(maxLength: 255, storeType: "nvarchar"),
                        lastName = c.String(maxLength: 255, storeType: "nvarchar"),
                        name = c.String(maxLength: 255, storeType: "nvarchar"),
                        role = c.String(maxLength: 255, storeType: "nvarchar"),
                        state = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("contract", "employee_id", "employee");
            DropForeignKey("payroll", "employee_id", "employee");
            DropForeignKey("employee", "local_id", "local");
            DropForeignKey("material", "supplier_id_supp", "supplier");
            DropForeignKey("material", "local_id", "local");
            DropForeignKey("transfer", "account_id", "account");
            DropForeignKey("transaction", "account_id", "account");
            DropForeignKey("draft", "account_id", "account");
            DropForeignKey("account", "client_id", "client");
            DropIndex("payroll", new[] { "employee_id" });
            DropIndex("material", new[] { "supplier_id_supp" });
            DropIndex("material", new[] { "local_id" });
            DropIndex("employee", new[] { "local_id" });
            DropIndex("contract", new[] { "employee_id" });
            DropIndex("transfer", new[] { "account_id" });
            DropIndex("transaction", new[] { "account_id" });
            DropIndex("draft", new[] { "account_id" });
            DropIndex("account", new[] { "client_id" });
            DropTable("meeting");
            DropTable("payroll");
            DropTable("supplier");
            DropTable("material");
            DropTable("local");
            DropTable("employee");
            DropTable("contract");
            DropTable("candidature");
            DropTable("transfer");
            DropTable("transaction");
            DropTable("draft");
            DropTable("client");
            DropTable("account");
        }
    }
}
