--====================================================================
-- Create database
--====================================================================
CREATE DATABASE MCAP_UW
GO

--====================================================================
-- Use database
--====================================================================
USE MCAP_UW
GO

--====================================================================
-- Create tables
--====================================================================
-- Table to store rate by product/program
IF  NOT EXISTS ( SELECT  1
                   FROM  sys.objects 
                  WHERE  type_desc   = 'USER_TABLE' 
                    AND  name      = 'tUWProdProgRate' 
                    AND  schema_id = schema_id('dbo') )
BEGIN  
                      
	CREATE TABLE [dbo].[tblUWProdProgRate]
	(
		 id                       int             not null identity(1,1) 
		,szProduct                varchar(30)     not null
		,dblProductRate           numeric(5,2)    not null
		,szProgram                varchar(30)     not null
		,dblProgRateAdj           numeric(5,2)    not null
		,dtPeriodStartDate        datetime        not null
		,dtPeriodEndDate          datetime        not null
	);

END

-- Code table
IF  NOT EXISTS ( SELECT  1
                   FROM  sys.objects 
                  WHERE  type_desc = 'USER_TABLE' 
                    AND  name      = 'tblDropDownList' 
                    AND  schema_id = schema_id('dbo') )
BEGIN  

	CREATE TABLE [dbo].[tblDropDownList]
	(
			id                    int             not null
		,szCode                   varchar(30)     not null
		,szValue                  varchar(100)    not null
	);

END

--====================================================================
-- Insert query to populate table
--====================================================================
INSERT INTO [dbo].[tblUWProdProgRate]
				(szProduct
				,dblProductRate
				,szProgram,dblProgRateAdj
				,dtPeriodStartDate
				,dtPeriodEndDate)
VALUES
	 ('3 Year Closed',	2.7,	'Standard',		-0.05,	'2017-09-01 00:00:00.000',	'2017-09-14 23:59:59.000')
	,('3 Year Closed',	2.7,	'Quick Close',	-0.1,	'2017-09-01 00:00:00.000',	'2017-09-14 23:59:59.000')
	,('5 Year Closed',	3.04,	'Standard',		-0.05,	'2017-09-01 00:00:00.000',	'2017-09-14 23:59:59.000')
	,('5 Year Closed',	3.04,	'Quick Close',	-0.1,	'2017-09-01 00:00:00.000',	'2017-09-14 23:59:59.000')
	,('3 Year Closed',	2.8,	'Standard',		-0.15,	'2017-09-15 00:00:00.000',	'2017-09-30 23:59:59.000')
	,('3 Year Closed',	2.8,	'Quick Close',	-0.22,	'2017-09-15 00:00:00.000',	'2017-09-30 23:59:59.000')
	,('5 Year Closed',	3.04,	'Standard',		-0.15,	'2017-09-15 00:00:00.000',	'2017-09-30 23:59:59.000')
	,('5 Year Closed',	3.04,	'Quick Close',	-0.22,	'2017-09-15 00:00:00.000',	'2017-09-30 23:59:59.000')
	,('3 Year Closed',	2.8,	'Standard',		-0.15,	'2017-10-01 00:00:00.000',	'2017-10-02 23:59:59.000')
	,('3 Year Closed',	2.8,	'Quick Close',	-0.2,	'2017-10-01 00:00:00.000',	'2017-10-02 23:59:59.000')
	,('5 Year Closed',	3.02,	'Standard',		-0.15,	'2017-10-01 00:00:00.000',	'2017-10-02 23:59:59.000')
	,('5 Year Closed',	3.02,	'Quick Close',	-0.2,	'2017-10-01 00:00:00.000',	'2017-10-02 23:59:59.000')
	,('3 Year Closed',	2.75,	'Standard',		-0.15,	'2017-10-03 00:00:00.000',	'2017-10-31 23:59:59.000')
	,('3 Year Closed',	2.75,	'Quick Close',	-0.15,	'2017-10-03 00:00:00.000',	'2017-10-31 23:59:59.000')
	,('5 Year Closed',	3.02,	'Standard',		-0.15,	'2017-10-03 00:00:00.000',	'2017-10-31 23:59:59.000')
	,('5 Year Closed',	3.02,	'Quick Close',	-0.15,	'2017-10-03 00:00:00.000',	'2017-10-31 23:59:59.000')



INSERT INTO [dbo].[tblDropDownList](id,szCode,szValue)
VALUES (1,'Product','3 Year Closed')
	  ,(2,'Product','5 Year Closed')
	  ,(1,'Program','Standard')
	  ,(2,'Program','Quick Close')