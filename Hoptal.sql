create database Hopital
use Hopital

create table specialite
(
id_specialite int identity primary key,
libelle varchar(25),
)

create table hopitale
(
id_hopital int primary key,
nom varchar(25),
adresse varchar(25),
ville varchar(25),
)

create table servicee
(
id_service int primary key,
id_hopitall# int foreign key references hopitale,
nbr_lit int,
)

create table medecin
(
id_medecin varchar(10) primary key,
nom varchar(25),
prenom varchar(25),
dtn date,
sexe varchar(10),
id_specialitee# int foreign key references specialite,
id_service int foreign key references servicee,
)

create table patient
(
id_patient int primary key,
nom varchar(25),
prenom varchar(25),
dtn date,
sexe varchar(10),
adresse varchar(25),
)

create table soigne
(
id_soin int primary key,
id_medecinn# varchar(10) foreign key references medecin,
id_patientt# int foreign key references patient,
nom_maladie varchar(25),
commentaire varchar(25),
date_soigne date,
)

create table sejourne
(
id_sejour int primary key,
id_servicee# int foreign key references servicee,
id_patientt# int foreign key references patient,
date_entree date,
date_sortie date,
)

INSERT [dbo].[specialite] ([libelle]) VALUES ('ophtalmogue')
INSERT [dbo].[specialite] ([libelle]) VALUES ('genicologue')
INSERT [dbo].[hopitale] ([id_hopital], [nom], [adresse], [ville]) VALUES (1, 'hoptal1', 'adress1', 'ville1')																			 
INSERT [dbo].[hopitale] ([id_hopital], [nom], [adresse], [ville]) VALUES (2, 'hoptal2', 'adress2', 'ville2')
INSERT [dbo].[servicee] ([id_service], [id_hopitall#], [nbr_lit]) VALUES (1, 1, 45)
INSERT [dbo].[servicee] ([id_service], [id_hopitall#], [nbr_lit]) VALUES (2, 2, 145)
INSERT [dbo].[medecin] ([id_medecin], [nom], [prenom], [dtn], [sexe], [id_specialitee#], [id_service]) VALUES ('F121212', 'nom_md1', 'prenom_md1','2000-05-15', 'homme', 1, 1)																									 
INSERT [dbo].[medecin] ([id_medecin], [nom], [prenom], [dtn], [sexe], [id_specialitee#], [id_service]) VALUES ('A458596', 'nom_md2', 'prenom_md2','2000-08-02', 'Femme', 2, 2)
INSERT [dbo].[patient] ([id_patient], [nom], [prenom], [dtn], [sexe], [adresse]) VALUES (1, 'nom_patient1','prenom_patient1', '2017-01-05', 'homme', 'adress1')
INSERT [dbo].[patient] ([id_patient], [nom], [prenom], [dtn], [sexe], [adresse]) VALUES (2, 'nom_patient2','prenom_patient2', '2017-07-05', 'homme', 'adress2')
INSERT [dbo].[patient] ([id_patient], [nom], [prenom], [dtn], [sexe], [adresse]) VALUES (3, 'nom_patient3','prenom_patient3', '2017-07-08', 'Femme', 'adress3')
INSERT [dbo].[patient] ([id_patient], [nom], [prenom], [dtn], [sexe], [adresse]) VALUES (4, 'nom_patient4','prenom_patient4', '2014-07-08', 'Femme', 'adress4') 																																									
INSERT [dbo].[patient] ([id_patient], [nom], [prenom], [dtn], [sexe], [adresse]) VALUES (5, 'nom_patient5','prenom_patient5', '2017-07-09', 'homme', 'adress5')																																									 
INSERT [dbo].[patient] ([id_patient], [nom], [prenom], [dtn], [sexe], [adresse]) VALUES (6, 'nom_patient6','prenom_patient6', '2017-12-08', 'Femme', 'adress6')
INSERT [dbo].[sejourne] ([id_sejour], [id_servicee#], [id_patientt#], [date_entree], [date_sortie]) VALUES (1, 1, 1, '2000-01-01' , '2000-01-10' )
INSERT [dbo].[sejourne] ([id_sejour], [id_servicee#], [id_patientt#], [date_entree], [date_sortie]) VALUES (2, 2, 2, '2012-04-05' , '2012-11-06' )
INSERT [dbo].[sejourne] ([id_sejour], [id_servicee#], [id_patientt#], [date_entree], [date_sortie]) VALUES (3, 1, 3, '2008-05-04' , '2008-06-04' )
INSERT [dbo].[sejourne] ([id_sejour], [id_servicee#], [id_patientt#], [date_entree], [date_sortie]) VALUES (4, 1, 4, '2008-05-10' , '2008-08-02' )
INSERT [dbo].[sejourne] ([id_sejour], [id_servicee#], [id_patientt#], [date_entree], [date_sortie]) VALUES (5, 2, 5, '2008-01-04' , '2008-06-09' )
INSERT [dbo].[sejourne] ([id_sejour], [id_servicee#], [id_patientt#], [date_entree], [date_sortie]) VALUES (6, 1, 6, '2008-04-04' , '2008-09-15' )
INSERT [dbo].[soigne] ([id_soin], [id_medecinn#], [id_patientt#], [nom_maladie], [commentaire], [date_soigne]) VALUES (1, 'F121212', 1, 'maladie1', 'commentaire1','2014-05-15')
INSERT [dbo].[soigne] ([id_soin], [id_medecinn#], [id_patientt#], [nom_maladie], [commentaire], [date_soigne]) VALUES (2, 'F121212', 2, 'maladie2', 'commentaire2','2014-08-09')																																		   
INSERT [dbo].[soigne] ([id_soin], [id_medecinn#], [id_patientt#], [nom_maladie], [commentaire], [date_soigne]) VALUES (3, 'F121212', 3, 'maladie3', 'commentaire3','2010-04-05')
INSERT [dbo].[soigne] ([id_soin], [id_medecinn#], [id_patientt#], [nom_maladie], [commentaire], [date_soigne]) VALUES (4, 'A458596', 4, 'maladie4', 'commentaire4','2009-08-01')
INSERT [dbo].[soigne] ([id_soin], [id_medecinn#], [id_patientt#], [nom_maladie], [commentaire], [date_soigne]) VALUES (5, 'A458596', 6, 'maladie5', 'commentaire5','2003-01-02')																																		   
INSERT [dbo].[soigne] ([id_soin], [id_medecinn#], [id_patientt#], [nom_maladie], [commentaire], [date_soigne]) VALUES (6, 'A458596', 5, 'maladie6', 'commentaire6','2007-09-05')

