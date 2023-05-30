USE [CreditCelesteAP]


-- Procedure stockée affToutRegionConcession

GO
CREATE PROCEDURE affToutRegionConcession

AS
BEGIN
  SELECT DISTINCT regionConcession from CONCESSION;
END
GO


-- Procedure stockée affVilleConcession

CREATE PROCEDURE affVilleConcession
  @regionConcession varchar(50)

AS
BEGIN
	SELECT DISTINCT villeConcession from CONCESSION where regionConcession = @regionConcession;
END
GO


-- Procedure stockée affCodeConcess

CREATE PROCEDURE affCodeConcess
  @regionConcession varchar(50),
  @villeConcession varchar(50)

AS
BEGIN
	select codeConcession from CONCESSION WHERE regionConcession = @regionConcession AND villeConcession = @villeConcession;
END
GO




-- procedure affVendeurs permet d'afficher tout les vendeurs
GO
CREATE PROCEDURE affVendeurs
  @codeConcession varchar(50)
AS
BEGIN
  SELECT cidVendeur, nomVendeur, prenomVendeur FROM VENDEUR WHERE codeConcession = @codeConcession
END
GO

-- EXECUTE affVendeurs


-- procedure stockée insertClient permet d'insérer le client dans la bdd
GO
CREATE PROCEDURE insertClient
  @cidCli varchar(50),
  @nomCli   varchar(50),
  @prenomCli   varchar(50),
  @telCli   varchar(50),
  @emailCli   varchar(50),
  @numRueCli   varchar(50),
  @rueCli   varchar(50),
  @villeCli   varchar(50),
  @cpCli   varchar(50)
  
AS
BEGIN
  INSERT INTO CreditCelesteAP.dbo.CLIENT(civilite ,nomClient, prenomClient, telClient, emailClient, numRueClient, rueClient, villeClient, cpClient)  
  VALUES (@cidCli, @nomCli, @prenomCli, @telCli, @emailCli, @numRueCli, @rueCli, @villeCli, @cpCli);
END
GO

-- EXECUTE insertClient M, jean, batiste, 01782376219, 'jj.bat@g.com', 7, 'Avenue de pierres', Lyon, 69000
					--('Monsieur','Romain', 'Louis', '0156349310', 'romain.louis@g.com', '5', 'Rue du poste', 'Strasbourg', '67000');




-- procedure recupCodeClient permet de recuperer le code du client
GO
CREATE PROCEDURE recupCodeClient
  @nomClient  varchar(50),
  @prenomClient varchar(50)

AS
BEGIN
SELECT codeClient FROM CLIENT WHERE nomClient = @nomClient AND prenomClient = @prenomClient;
END
GO



-- procedure recupCodeClient permet de recuperer le code du client
GO
CREATE PROCEDURE recupNumVendeur
  @nomVendeur   varchar(50),
  @prenomVendeur varchar(50)

AS
BEGIN
	SELECT numVendeur FROM VENDEUR WHERE nomVendeur = @nomVendeur AND prenomVendeur = @prenomVendeur;
END
GO







-- procedure stockée insertCredit permet d'insérer le credit dans la bdd
GO
CREATE PROCEDURE insertCredit
  @montantCredit varchar(50),
  @tauxCredit varchar(50),
  @dureeCredit varchar(50),
  @mensualite varchar(50),
  @dateSaisie varchar(50),
  @numVendeur INT,
  @codeClient INT,
  @codeValidation varchar(5),
  @codeCollab varchar(50),
  @codeConcession varchar(50)

  
AS
BEGIN
  INSERT INTO CreditCelesteAP.dbo.CREDIT(montantCredit, tauxCredit, dureeCredit, mensualite, dateSaisie, numVendeur,  codeClient, codeValidation, codeCollab, codeConcession) 
  VALUES (@montantCredit, @tauxCredit, @dureeCredit, @mensualite, @dateSaisie, @numVendeur, @codeClient, @codeValidation, @codeCollab, @codeConcession );

END
GO


-- procedure stockée recupereConcByRegionVille permet de recuperer le code de la concession et le nom dans la bdd
GO
CREATE PROCEDURE recupereConcByRegionVille
    @region NVARCHAR(50),
    @ville NVARCHAR(50)
AS
BEGIN
    SELECT codeConcession, nomConcession, telConcession, emailConcession, stockVehicule, COLLABORATEUR.codeCollab, COLLABORATEUR.nomCollab, COLLABORATEUR.prenomCollab
    FROM CONCESSION, COLLABORATEUR
    WHERE regionConcession = @region AND villeConcession = @ville AND CONCESSION.codeCollab = COLLABORATEUR.codeCollab
END
GO

-- Permet de recuperer les marques de voitures de la concession
CREATE PROCEDURE recupMarqueConcession
    @codeConcession varchar(50)
AS
BEGIN
    SELECT DISTINCT marque, modele, anneeModele, energie, numImmat, numSerie, puissance, datePremImmat, prixVehicule
    FROM vehicule
    WHERE codeConcession = @codeConcession
END

GO
-- Permet de recuperer les modeles de voitures de la concession par rapport à la marque
CREATE PROCEDURE recupModeleMarqueConcession
    @marque varchar(50),
    @codeConcession varchar(50)
AS
BEGIN
    SELECT DISTINCT marque, modele, anneeModele, energie, numImmat, numSerie, puissance, datePremImmat, prixVehicule
    FROM vehicule
    WHERE marque = @marque AND codeConcession = @codeConcession
END


-- Permet de recuperer les annees de voitures de la concession par rapport à la marque, modele
GO
CREATE PROCEDURE recupAnneeModeleMarqueConcession
    @marque varchar(50),
    @modele varchar(50),
    @codeConcession varchar(50)
AS
BEGIN
    SELECT DISTINCT marque, modele, anneeModele, energie, numImmat, numSerie, puissance, datePremImmat, prixVehicule
    FROM vehicule
    WHERE marque = @marque AND modele = @modele AND codeConcession = @codeConcession
END


-- Permet de recuperer les energie (diesel, essence) de voitures de la concession par rapport à la marque, modele, annee
GO
CREATE PROCEDURE recupEnergieAnneeModeleMarqueConcession
    @marque varchar(50),
    @modele varchar(50),
    @anneeModele varchar(50),
    @codeConcession varchar(50)
AS
BEGIN
    SELECT DISTINCT marque, modele, anneeModele, energie, numImmat, numSerie, puissance, datePremImmat, prixVehicule
    FROM vehicule
    WHERE marque = @marque AND modele = @modele AND anneeModele = @anneeModele AND codeConcession = @codeConcession
END



-- Permet de recuperer la puissance de voitures de la concession par rapport à la marque, modele, annee, energie
GO
CREATE PROCEDURE recupPuissanceEnergieAnneeModeleMarqueConcession
    @marque varchar(50),
    @modele varchar(50),
    @anneeModele varchar(50),
    @energie varchar(50),
    @codeConcession varchar(50)
AS
BEGIN
    SELECT DISTINCT marque, modele, anneeModele, energie, numImmat, numSerie, puissance, datePremImmat, prixVehicule
    FROM vehicule
    WHERE marque = @marque AND modele = @modele AND anneeModele = @anneeModele AND energie = @energie AND codeConcession = @codeConcession
END

-- Permet de recuperer l'image de la voiture de la concession par rapport à la marque, modele, annee, energie
GO
CREATE PROCEDURE recupImageVoiture
    @marque varchar(50),
    @modele varchar(50),
    @anneeModele varchar(50),
    @energie varchar(50),
    @codeConcession varchar(50)
AS
BEGIN
    SELECT imageVehicule
    FROM vehicule
    WHERE marque = @marque AND modele = @modele AND anneeModele = @anneeModele AND energie = @energie AND codeConcession = @codeConcession
END


-- Permet d'etudier tout les credit de la concession afin d'accepter ou refuser le credit
GO
CREATE PROCEDURE affCreditEtude
 @codeConcession varchar(50)
AS
BEGIN

  SELECT numCredit,nomClient, prenomClient, montantCredit, tauxCredit, dureeCredit, mensualite, codeValidation
  FROM CLIENT, CREDIT
  WHERE CLIENT.codeClient = CREDIT.codeClient
  AND codeValidation = 'E'
  AND codeConcession = @codeConcession
END

-- Permet d'etudier un credit et en changeant le codeValidation (refuser ou valider le credit)
GO
CREATE PROCEDURE etudierCredit
    @numCredit INT,
    @codeValidation VARCHAR(50)
AS
BEGIN
    UPDATE credit
    SET codeValidation = @codeValidation
    WHERE numCredit = @numCredit
END


GO
/****** Object:  StoredProcedure [dbo].[affCreditEtude]    Script Date: 14/05/2023 16:44:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[affCreditRelance]
 @codeConcession varchar(50)
AS
BEGIN

  SELECT numCredit,nomClient, prenomClient, montantCredit, tauxCredit, dureeCredit, mensualite, codeValidation
  FROM CLIENT, CREDIT
  WHERE CLIENT.codeClient = CREDIT.codeClient
  AND codeValidation = 'R'
  AND codeConcession = @codeConcession
END

-- Permet d'afficher un credit  pour relancer celui-ci




-- ordre de suppression des tables manuellement
-- vehicule
-- credit
-- client
-- vendeur
-- concession
-- collaborateur
-- agence 
-- credit_celeste