USE [CreditCelesteAP]

--  Insertion Credit_CELESTE

INSERT INTO CREDIT_CELESTE(numSiret, telCC, numRueCC,rueCC, villeCC, cpCC, nomPDGCC, prenomPDGCC)
VALUES('1','0156349310', '5', 'Avenue du credit celeste', 'Paris', '75000', 'Flitz', 'François');

GO
--  Insertion AGENCE

--  Agence Alsace/Strasbourg
INSERT INTO AGENCE(codeAgence, nomAgence, telAgence, emailAgence, regionAgence, villeAgence, nbEmploye, numSiret)
VALUES('AG1','Credit AaP', '0156349310', 'credit.Aap@creditC.com', 'Alsace', 'Strasbourg', '8', '1');
GO
--  Agence Île-de-France/Paris
INSERT INTO AGENCE(codeAgence, nomAgence, telAgence, emailAgence, regionAgence, villeAgence, nbEmploye, numSiret)
VALUES('AG2','Credit AbG', '0156349310', 'credit.AbG@creditC.com', 'Île-de-France', 'Paris', '6', '1');
GO
--  Agence Rhône-Alpes/Lyon
INSERT INTO AGENCE(codeAgence, nomAgence, telAgence, emailAgence, regionAgence, villeAgence, nbEmploye, numSiret)
VALUES('AG3','Credit AcK', '0156349310', 'credit.AcK@creditC.com', 'Rhône-Alpes', 'Lyon', '12', '1');
GO
--  Agence Bouches-du-Rhône/Marseille
INSERT INTO AGENCE(codeAgence, nomAgence, telAgence, emailAgence, regionAgence, villeAgence, nbEmploye, numSiret)
VALUES('AG4','Credit AeQ', '0156349310', 'credit.AeQ@creditC.com', 'Bouches-du-Rhône', 'Marseille', '11', '1');
GO


-- Insertion Collaborateur

INSERT INTO COLLABORATEUR(codeCollab, nomCollab, prenomCollab, telCollab, emailCollab, codeAgence)
VALUES('COLL1','Kopa', 'Franck', '0156349310', 'kopa.franck@creditC.com', 'AG1');
GO
INSERT INTO COLLABORATEUR(codeCollab, nomCollab, prenomCollab, telCollab, emailCollab, codeAgence)
VALUES('COLL2','Shpot', 'Erick', '0156349310', 'shpot.erick@creditC.com', 'AG2');
GO
INSERT INTO COLLABORATEUR(codeCollab, nomCollab, prenomCollab, telCollab, emailCollab, codeAgence)
VALUES('COLL3','Mloa', 'Batiste', '0156349310', 'mloa.batiste@creditC.com', 'AG3');
GO
INSERT INTO COLLABORATEUR(codeCollab, nomCollab, prenomCollab, telCollab, emailCollab, codeAgence)
VALUES('COLL4','Wrap', 'Mout', '0156349310', 'wrap.mout@creditC.com', 'AG4');
GO

-- Insertion Concession

INSERT INTO CONCESSION(codeConcession, nomConcession, telConcession, emailConcession, regionConcession, villeConcession, stockVehicule, codeAgence, codeCollab)
VALUES('CONC1','CarLuxury', '0156349310', 'carluxury@conc.com', 'Alsace', 'Strasbourg', '27', 'AG1', 'COLL1');
GO
INSERT INTO CONCESSION(codeConcession, nomConcession, telConcession, emailConcession, regionConcession, villeConcession, stockVehicule, codeAgence, codeCollab)
VALUES('CONC2','AutoExpress', '0156349310', 'autoexpress@conc.com', 'Alsace', 'Haguenau', '44', 'AG1', 'COLL1');
GO
INSERT INTO CONCESSION(codeConcession, nomConcession, telConcession, emailConcession, regionConcession, villeConcession, stockVehicule, codeAgence, codeCollab)
VALUES('CONC3','PrestigeAuto', '0156349310', 'prestigeauto@conc.com', 'Île-de-France', 'Paris', '54', 'AG2', 'COLL2');
GO
INSERT INTO CONCESSION(codeConcession, nomConcession, telConcession, emailConcession, regionConcession, villeConcession, stockVehicule, codeAgence, codeCollab)
VALUES('CONC4','Carich G', '0156349310', 'arichg@conc.com', 'Île-de-France', 'La Défense', '32', 'AG2', 'COLL2');
GO
INSERT INTO CONCESSION(codeConcession, nomConcession, telConcession, emailConcession, regionConcession, villeConcession, stockVehicule, codeAgence, codeCollab)
VALUES('CONC5','Wolf Park', '0156349310', 'wolfpark@conc.com', 'Rhône-Alpes', 'Lyon', '34', 'AG3', 'COLL3');
GO
INSERT INTO CONCESSION(codeConcession, nomConcession, telConcession, emailConcession, regionConcession, villeConcession, stockVehicule, codeAgence, codeCollab)
VALUES('CONC6','AutoPresto', '0156349310', 'autopresto@conc.com', 'Rhône-Alpes', 'Annecy', '29', 'AG3', 'COLL3');
GO
INSERT INTO CONCESSION(codeConcession, nomConcession, telConcession, emailConcession, regionConcession, villeConcession, stockVehicule, codeAgence, codeCollab)
VALUES('CONC7','CashCar', '0156349310', 'cashcar@conc.com', 'Bouches-du-Rhône', 'Marseille', '54', 'AG4', 'COLL4');
GO
INSERT INTO CONCESSION(codeConcession, nomConcession, telConcession, emailConcession, regionConcession, villeConcession, stockVehicule, codeAgence, codeCollab)
VALUES('CONC8','Volt Auto', '0156349310', 'voltauto@conc.com', 'Bouches-du-Rhône', 'Aix-en-Provence', '48', 'AG4', 'COLL4');
GO


-- Insertion Vehicule


INSERT INTO VEHICULE(numVehicule, marque, modele, anneeModele, numImmat, numSerie, puissance, datePremImmat, energie, codeConcession, prixVehicule, imageVehicule)
VALUES
('1', 'Peugeot', '208', '2020', 'AB-1234-CD', '0123456789', '100', '2020-01-01', 'Essence', 'CONC1', '18000', NULL),
('2', 'Peugeot', '3008', '2019', 'EF-5678-GH', '1234567890', '130', '2019-06-01', 'Diesel', 'CONC1', '22000', NULL),
('3', 'Renault', 'Clio', '2021', 'IJ-9012-KL', '2345678901', '100', '2021-02-15', 'Essence', 'CONC1', '15000', NULL),
('4', 'Renault', 'Captur', '2022', 'MN-3456-OP', '3456789012', '120', '2022-03-01', 'Essence', 'CONC1', '20000', NULL),
('5', 'Volkswagen', 'Polo', '2019', 'QR-7890-ST', '4567890123', '95', '2019-08-01', 'Essence', 'CONC1', '16000', NULL),
('6', 'Volkswagen', 'T-Roc', '2020', 'UV-2345-WX', '5678901234', '150', '2020-11-15', 'Diesel', 'CONC1', '28000', NULL),
('7', 'Ford', 'Fiesta', '2022', 'AB-6789-CD', '6789012345', '100', '2022-02-01', 'Essence', 'CONC1', '16000', NULL),
('8', 'Ford', 'Puma', '2021', 'EF-1234-GH', '7890123456', '125', '2021-05-15', 'Essence', 'CONC1', '22000', NULL),
('9', 'Toyota', 'Yaris', '2021', 'IJ-5678-KL', '8901234567', '90', '2021-03-01', 'Essence', 'CONC1', '17000', NULL),
('10', 'Toyota', 'C-HR', '2022', 'MN-9012-OP', '9012345678', '122', '2022-04-15', 'Hybride', 'CONC1', '29000', NULL);

GO

INSERT INTO VEHICULE(numVehicule, marque, modele, anneeModele, numImmat, numSerie, puissance, datePremImmat, energie, codeConcession, prixVehicule, imageVehicule)
VALUES
  ('11', 'Toyota', 'Yaris', '2021', 'AB-1234-CD', '1234567890', '90', '2021-01-01', 'Essence', 'CONC2', '17000', null),
  ('12', 'Toyota', 'C-HR', '2022', 'EF-5678-GH', '2345678901', '122', '2022-03-15', 'Hybride', 'CONC2', '29000', null),
  ('13', 'Peugeot', '208', '2020', 'IJ-9012-KL', '3456789012', '100', '2020-06-01', 'Essence', 'CONC2', '18000', null),
  ('14', 'Peugeot', '3008', '2019', 'MN-3456-OP', '4567890123', '130', '2019-09-22', 'Diesel', 'CONC2', '22000', null),
  ('15', 'Renault', 'Clio', '2021', 'QR-7890-ST', '5678901234', '100', '2021-02-28', 'Essence', 'CONC2', '15000', null),
  ('16', 'Renault', 'Captur', '2022', 'UV-1234-WX', '6789012345', '120', '2022-04-01', 'Essence', 'CONC2', '20000', null),
  ('17', 'Volkswagen', 'Polo', '2019', 'YZ-5678-AB', '7890123456', '95', '2019-07-15', 'Essence', 'CONC2', '16000', null),
  ('18', 'Volkswagen', 'T-Roc', '2020', 'CD-9012-EF', '8901234567', '150', '2020-10-01', 'Diesel', 'CONC2', '28000', null),
  ('19', 'Ford', 'Fiesta', '2022', 'GH-3456-IJ', '9012345678', '100', '2022-01-01', 'Essence', 'CONC2', '16000', null),
  ('20', 'Ford', 'Puma', '2021', 'KL-7890-MN', '2345678901', '125', '2021-04-15', 'Essence', 'CONC2', '22000', null); 

GO

INSERT INTO VEHICULE(numVehicule, marque, modele, anneeModele, numImmat, numSerie, puissance, datePremImmat, energie, codeConcession, prixVehicule, imageVehicule)
VALUES
  ('21', 'Toyota', 'Yaris', '2021', 'FG-5678-PL', '9012345678', '90', '2021-01-01', 'Essence', 'CONC3', '17000', null),
  ('22', 'Toyota', 'C-HR', '2022', 'TJ-6789-ZP', '2345678901', '122', '2022-03-15', 'Hybride', 'CONC3', '29000', null),
  ('23', 'Peugeot', '208', '2020', 'SD-7890-TY', '3456789012', '100', '2020-06-01', 'Essence', 'CONC3', '18000', null),
  ('24', 'Peugeot', '3008', '2019', 'JV-9012-FG', '4567890123', '130', '2019-09-22', 'Diesel', 'CONC3', '22000', null),
  ('25', 'Renault', 'Clio', '2021', 'TY-1234-SQ', '5678901234', '100', '2021-02-28', 'Essence', 'CONC3', '15000', null),
  ('26', 'Renault', 'Captur', '2022', 'ZX-4567-RT', '6789012345', '120', '2022-04-01', 'Essence', 'CONC3', '20000', null),
  ('27', 'Volkswagen', 'Polo', '2019', 'VN-8910-WX', '7890123456', '95', '2019-07-15', 'Essence', 'CONC3', '16000', null),
  ('28', 'Volkswagen', 'T-Roc', '2020', 'LK-2345-UY', '8901234567', '150', '2020-10-01', 'Diesel', 'CONC3', '28000', null),
  ('29', 'Ford', 'Fiesta', '2022', 'RV-6789-KJ', '9012345678', '100', '2022-01-01', 'Essence', 'CONC3', '16000', null),
  ('30', 'Ford', 'Puma', '2021', 'JH-7890-CX', '2345678901', '125', '2021-04-15', 'Essence', 'CONC3', '22000', null);

GO

INSERT INTO VEHICULE(numVehicule, marque, modele, anneeModele, numImmat, numSerie, puissance, datePremImmat, energie, codeConcession, prixVehicule, imageVehicule)
VALUES
  ('31', 'Ford', 'Focus', '2021', 'FG-5678-PL', '9012345678', '120', '2021-01-01', 'Essence', 'CONC3', '20000', null),
  ('32', 'Ford', 'Kuga', '2022', 'TJ-6789-ZP', '2345678901', '150', '2022-03-15', 'Hybride', 'CONC3', '32000', null),
  ('33', 'Renault', 'Mégane', '2020', 'SD-7890-TY', '3456789012', '130', '2020-06-01', 'Essence', 'CONC3', '24000', null),
  ('34', 'Renault', 'Kadjar', '2019', 'JV-9012-FG', '4567890123', '140', '2019-09-22', 'Diesel', 'CONC3', '27000', null),
  ('35', 'Peugeot', '308', '2021', 'TY-1234-SQ', '5678901234', '120', '2021-02-28', 'Essence', 'CONC3', '19000', null),
  ('36', 'Peugeot', '3008', '2022', 'ZX-4567-RT', '6789012345', '150', '2022-04-01', 'Essence', 'CONC3', '29000', null),
  ('37', 'Volkswagen', 'Golf', '2019', 'VN-8910-WX', '7890123456', '110', '2019-07-15', 'Essence', 'CONC3', '21000', null),
  ('38', 'Volkswagen', 'Tiguan', '2020', 'LK-2345-UY', '8901234567', '140', '2020-10-01', 'Diesel', 'CONC3', '33000', null),
  ('39', 'Toyota', 'Corolla', '2022', 'RV-6789-KJ', '9012345678', '130', '2022-01-01', 'Essence', 'CONC3', '22000', null),
  ('40', 'Toyota', 'RAV4', '2021', 'JH-7890-CX', '2345678901', '160', '2021-04-15', 'Hybride', 'CONC3', '35000', null);

GO

INSERT INTO VEHICULE(numVehicule, marque, modele, anneeModele, numImmat, numSerie, puissance, datePremImmat, energie, codeConcession, prixVehicule)
VALUES
  ('41', 'Audi', 'A3', '2022', 'XY-1234-AB', '3456789012', '150', '2022-02-15', 'Diesel', 'CONC4', '35000'),
  ('42', 'Audi', 'Q3', '2021', 'ST-5678-CD', '4567890123', '170', '2021-05-01', 'Essence', 'CONC4', '45000'),
  ('43', 'BMW', 'Série 1', '2020', 'UV-9012-EF', '5678901234', '140', '2020-09-22', 'Diesel', 'CONC4', '32000'),
  ('44', 'BMW', 'X5', '2019', 'GH-2345-HI', '6789012345', '200', '2019-12-01', 'Essence', 'CONC4', '65000'),
  ('45', 'Mercedes', 'Classe A', '2022', 'KL-6789-JK', '9012345678', '180', '2022-03-15', 'Hybride', 'CONC4', '50000'),
  ('46', 'Mercedes', 'GLC', '2021', 'MN-8901-LM', '2345678901', '250', '2021-06-01', 'Diesel', 'CONC4', '75000'),
  ('47', 'Jaguar', 'F-PACE', '2020', 'OP-2345-NP', '3456789012', '300', '2020-09-22', 'Essence', 'CONC4', '80000'),
  ('48', 'Jaguar', 'XE', '2022', 'QR-5678-RS', '4567890123', '200', '2022-01-01', 'Diesel', 'CONC4', '55000'),
  ('49', 'Tesla', 'Model 3', '2022', 'TU-9012-VT', '5678901234', '400', '2022-04-15', 'Electrique', 'CONC4', '85000'),
  ('50', 'Tesla', 'Model Y', '2021', 'WX-1234-XY', '6789012345', '450', '2021-07-15', 'Electrique', 'CONC4', '90000');

GO

INSERT INTO VEHICULE(numVehicule, marque, modele, anneeModele, numImmat, numSerie, puissance, datePremImmat, energie, codeConcession, prixVehicule)
VALUES
  ('51', 'Peugeot', '208', '2022', 'SD-4567-GT', '3456789012', '110', '2022-01-01', 'Essence', 'CONC5', '19000'),
  ('52', 'Peugeot', '3008', '2021', 'JV-7890-FG', '4567890123', '130', '2021-05-15', 'Diesel', 'CONC5', '24000'),
  ('53', 'Renault', 'Clio', '2022', 'TY-2345-HJ', '5678901234', '100', '2022-03-01', 'Essence', 'CONC5', '17000'),
  ('54', 'Renault', 'Captur', '2022', 'ZX-5678-KL', '6789012345', '120', '2022-02-15', 'Essence', 'CONC5', '21000'),
  ('55', 'Volkswagen', 'Golf', '2021', 'VN-9012-MN', '7890123456', '150', '2021-06-01', 'Diesel', 'CONC5', '28000'),
  ('56', 'Volkswagen', 'Touareg', '2022', 'LK-3456-PQ', '8901234567', '210', '2022-04-15', 'Hybride', 'CONC5', '54000'),
  ('57', 'Ford', 'Focus', '2022', 'RV-7890-ST', '9012345678', '120', '2022-01-01', 'Essence', 'CONC5', '19000'),
  ('58', 'Ford', 'Kuga', '2021', 'JH-2345-UV', '2345678901', '150', '2021-09-15', 'Diesel', 'CONC5', '29000'),
  ('59', 'Toyota', 'Corolla', '2022', 'FG-6789-WX', '3456789012', '140', '2022-03-01', 'Hybride', 'CONC5', '32000'),
  ('60', 'Toyota', 'Rav4', '2021', 'TJ-1234-YZ', '4567890123', '180', '2021-06-01', 'Hybride', 'CONC5', '40000');

GO

INSERT INTO VEHICULE(numVehicule, marque, modele, anneeModele, numImmat, numSerie, puissance, datePremImmat, energie, codeConcession, prixVehicule)
VALUES
  ('61', 'Renault', 'Mégane', '2022', 'TY-2345-HJ', '5678901234', '120', '2022-03-01', 'Essence', 'CONC6', '20000'),
  ('62', 'Renault', 'Kadjar', '2022', 'ZX-5678-KL', '6789012345', '130', '2022-02-15', 'Diesel', 'CONC6', '25000'),
  ('63', 'Peugeot', '308', '2022', 'VN-9012-MN', '7890123456', '150', '2022-01-01', 'Essence', 'CONC6', '28000'),
  ('64', 'Peugeot', '5008', '2021', 'LK-3456-PQ', '8901234567', '180', '2021-04-15', 'Diesel', 'CONC6', '32000'),
  ('65', 'Volkswagen', 'Passat', '2022', 'RV-7890-ST', '9012345678', '170', '2022-05-01', 'Hybride', 'CONC6', '36000'),
  ('66', 'Volkswagen', 'Tiguan', '2021', 'JH-2345-UV', '2345678901', '150', '2021-09-15', 'Diesel', 'CONC6', '29000'),
  ('67', 'Ford', 'Fiesta', '2022', 'FG-6789-WX', '3456789012', '100', '2022-03-01', 'Essence', 'CONC6', '17000'),
  ('68', 'Ford', 'Puma', '2021', 'TJ-1234-YZ', '4567890123', '120', '2021-06-01', 'Essence', 'CONC6', '21000'),
  ('69', 'Toyota', 'Yaris', '2022', 'SD-4567-GT', '3456789012', '90', '2022-01-01', 'Hybride', 'CONC6', '22000'),
  ('70', 'Toyota', 'C-HR', '2021', 'JV-7890-FG', '4567890123', '110', '2021-05-15', 'Hybride', 'CONC6', '28000');

GO

INSERT INTO VEHICULE(numVehicule, marque, modele, anneeModele, numImmat, numSerie, puissance, datePremImmat, energie, codeConcession, prixVehicule)
VALUES
  ('71', 'Peugeot', '208', '2022', 'SD-4567-GT', '3456789012', '110', '2022-01-01', 'Essence', 'CONC7', '19000'),
  ('72', 'Peugeot', '3008', '2021', 'JV-7890-FG', '4567890123', '130', '2021-05-15', 'Diesel', 'CONC7', '24000'),
  ('73', 'Renault', 'Clio', '2022', 'TY-2345-HJ', '5678901234', '100', '2022-03-01', 'Essence', 'CONC7', '17000'),
  ('74', 'Renault', 'Captur', '2022', 'ZX-5678-KL', '6789012345', '120', '2022-02-15', 'Essence', 'CONC7', '21000'),
  ('75', 'Volkswagen', 'Golf', '2021', 'VN-9012-MN', '7890123456', '150', '2021-06-01', 'Diesel', 'CONC7', '28000'),
  ('76', 'Volkswagen', 'Touareg', '2022', 'LK-3456-PQ', '8901234567', '210', '2022-04-15', 'Hybride', 'CONC7', '54000'),
  ('77', 'Ford', 'Focus', '2022', 'RV-7890-ST', '9012345678', '120', '2022-01-01', 'Essence', 'CONC7', '19000'),
  ('78', 'Ford', 'Kuga', '2021', 'JH-2345-UV', '2345678901', '150', '2021-09-15', 'Diesel', 'CONC7', '29000'),
  ('79', 'Toyota', 'Corolla', '2022', 'FG-6789-WX', '3456789012', '140', '2022-03-01', 'Hybride', 'CONC7', '32000'),
  ('80', 'Toyota', 'Rav4', '2021', 'TJ-1234-YZ', '4567890123', '180', '2021-06-01', 'Hybride', 'CONC7', '40000');

  GO

INSERT INTO VEHICULE(numVehicule, marque, modele, anneeModele, numImmat, numSerie, puissance, datePremImmat, energie, codeConcession, prixVehicule)
VALUES
  ('81', 'Peugeot', '308', '2022', 'SD-4567-GT', '3456789012', '130', '2022-01-01', 'Essence', 'CONC8', '24000'),
  ('82', 'Peugeot', '5008', '2021', 'JV-7890-FG', '4567890123', '150', '2021-05-15', 'Diesel', 'CONC8', '29000'),
  ('83', 'Renault', 'Megane', '2022', 'TY-2345-HJ', '5678901234', '120', '2022-03-01', 'Essence', 'CONC8', '20000'),
  ('84', 'Renault', 'Kadjar', '2022', 'ZX-5678-KL', '6789012345', '150', '2022-02-15', 'Diesel', 'CONC8', '28000'),
  ('85', 'Volkswagen', 'Polo', '2021', 'VN-9012-MN', '7890123456', '90', '2021-06-01', 'Essence', 'CONC8', '18000'),
  ('86', 'Volkswagen', 'Tiguan', '2022', 'LK-3456-PQ', '8901234567', '180', '2022-04-15', 'Hybride', 'CONC8', '43000'),
  ('87', 'Ford', 'Fiesta', '2022', 'RV-7890-ST', '9012345678', '100', '2022-01-01', 'Essence', 'CONC8', '17000'),
  ('88', 'Ford', 'Escape', '2021', 'JH-2345-UV', '2345678901', '150', '2021-09-15', 'Diesel', 'CONC8', '31000'),
  ('89', 'Toyota', 'Yaris', '2022', 'FG-6789-WX', '3456789012', '110', '2022-03-01', 'Hybride', 'CONC8', '26000'),
  ('90', 'Toyota', 'Highlander', '2021', 'TJ-1234-YZ', '4567890123', '240', '2021-06-01', 'Hybride', 'CONC8', '56000');

  GO

  --  Insertion Vendeur

INSERT INTO VENDEUR  
         (cidVendeur, nomVendeur, prenomVendeur, codeConcession)  
VALUES   ('M','jean', 'louis','CONC1');
 GO
INSERT INTO VENDEUR  
         (cidVendeur, nomVendeur, prenomVendeur, codeConcession)   
VALUES   ('M','paul', 'jack', 'CONC2');
 GO
INSERT INTO VENDEUR  
        (cidVendeur, nomVendeur, prenomVendeur, codeConcession)    
VALUES   ('Mme','julie', 'pauline', 'CONC3');


-- -----------
GO

INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('M','Jean', 'Paul', 'CONC1');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('M','Pierre', 'Luc', 'CONC1');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('Mme','Marie', 'Claire', 'CONC1');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('M','Jacques', 'Pierre', 'CONC1');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('Mme','Sophie', 'Lucie', 'CONC1');

GO

INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('Mme','Julie', 'Pierre', 'CONC2');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('M','Antoine', 'François', 'CONC2');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('Mme','Céline', 'Marie', 'CONC2');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('M','David', 'Sylvain', 'CONC2');

GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('Mme','Camille', 'Jeanne','CONC3');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('M','Guillaume', 'Paul', 'CONC3');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('Mme','Anne', 'Sophie', 'CONC3');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('M','Étienne', 'Lucas', 'CONC3');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('Mme','Hélène', 'Marie', 'CONC3');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('M','Robert', 'Pierre','CONC4');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('Mme','Dupont', 'Sophie', 'CONC4');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('M','Tremblay', 'Louis', 'CONC4');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('Mme','Laroche', 'Anne', 'CONC4');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('M','Girard', 'Maxime', 'CONC4');
GO

INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('Mme','Moreau', 'Lucie','CONC5');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('M','Lefebvre', 'Antoine', 'CONC5');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('M','Leclerc', 'Bruno', 'CONC5');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('Mme','Fournier', 'Chantal', 'CONC5');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('M','Gagnon', 'Simon', 'CONC5');
GO

INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('Mme','Lapointe', 'Marie','CONC6');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('M','Gaudreau', 'Michel', 'CONC6');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('Mme','Beaulieu', 'Amélie', 'CONC6');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('M','Deschamps', 'Louis', 'CONC6');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('Mme','Lemieux', 'Catherine', 'CONC6');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('M', 'François', 'Luc', 'CONC7');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('M', 'Alexandre', 'Nicolas', 'CONC7');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('Mme', 'Sophie', 'Emma', 'CONC7');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('M', 'Antoine', 'Olivier', 'CONC7');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('M', 'Vincent', 'Julien', 'CONC7');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('M', 'Stéphane', 'Nicolas', 'CONC8');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('M', 'Guillaume', 'Théo', 'CONC8');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('Mme', 'Aurélie', 'Charlotte', 'CONC8');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('M', 'Matthieu', 'Julien', 'CONC8');
GO
INSERT INTO VENDEUR
(cidVendeur, nomVendeur, prenomVendeur, codeConcession)
VALUES ('M', 'Romain', 'Thibaut', 'CONC8');


-- Insertion client
GO
INSERT INTO CLIENT  
         (civilite ,nomClient, prenomClient, telClient, emailClient, numRueClient, rueClient, villeClient, cpClient)  
VALUES   ('Monsieur','Romain', 'Louis', '0156349310', 'romain.louis@g.com', '5', 'Rue du poste', 'Strasbourg', '67000');
GO
INSERT INTO CLIENT  
         (civilite ,nomClient, prenomClient, telClient, emailClient, numRueClient, rueClient, villeClient, cpClient)  
VALUES   ('Monsieur','Gabriel', 'Leo', '0156349310', 'gabriel.leo@g.com', '6', 'Rue du bateau', 'Paris', '75000');
GO
INSERT INTO CLIENT  
         (civilite ,nomClient, prenomClient, telClient, emailClient, numRueClient, rueClient, villeClient, cpClient)   
VALUES   ('Madame', 'Sophie', 'Gift', '0156349310', 'sophie.gift@g.com', '4', 'Avenue de louvrier', 'Marseille', '13000');


-- Insertion credit
GO
INSERT INTO CREDIT(montantCredit, tauxCredit, dureeCredit, mensualite, dateSaisie, debutCredit, finCredit, numVendeur, codeClient, codeValidation, codeCollab)
VALUES('10000', '3', '24', '679', '29-11-2022', '01-12-2022', '01-12-2024', '1', '1', 'E', 'COLL1');
GO
INSERT INTO CREDIT(montantCredit, tauxCredit, dureeCredit, mensualite, dateSaisie, debutCredit, finCredit, numVendeur, codeClient, codeValidation, codeCollab)
VALUES('50000', '2', '14', '412', '29-11-2022', '01-12-2022', '01-12-2023', '2', '2', 'E', 'COLL1');
GO
INSERT INTO CREDIT(montantCredit, tauxCredit, dureeCredit, mensualite, dateSaisie, debutCredit, finCredit, numVendeur, codeClient, codeValidation, codeCollab)
VALUES('37000', '2', '48', '349', '29-11-2022', '01-12-2022', '01-12-2026', '3', '3', 'E', 'COLL2');