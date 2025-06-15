# BOSTE c-SHARP : Mini Projet CRUD C# ASP.NET Core

## Description

Ity application ity de natao izany mba higerena liste an'olona na personne
(resaka CRUD ilay atao eto) 

## ETO NY ETAPE NANAOVANA AZY MIARAKA @commande TERMINAL
1. Création du projet
   ```bash
   dotnet new razor -n CrudWebApp
   ```

2. Ajout du modèle
   - Création d’une classe `Personne` avec les propriétés Id, Nom, Prénom.

3. Création du contexte de données
   - Ajout d’un DbContext pour gérer les personnes.

4. Ajout des pages Razor CRUD
   - Génération ou création manuelle des pages : Index, Create, Edit, Delete.

5. Migration et base de données
   ```bash
   dotnet tool install --global dotnet-ef
   dotnet add package Microsoft.EntityFrameworkCore.Sqlite
   dotnet add package Microsoft.EntityFrameworkCore.Design
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

6. Lancement de l’application
   ```bash
   dotnet run
   ```

7. Personnalisation de l’interface
   - Modification du layout, ajout d’un grand titre, amélioration du footer, ajout d’un scroll sur la liste, suppression des pages par défaut, nettoyage des fichiers/dossiers vides.


## Utilisation

- Accédez à l’application via `http://localhost:xxxx/Personnes`
- Utilisez les boutons pour ajouter, modifier ou supprimer des personnes.


Résumé :  
ITY PROJET ITY DE APK CRUD VITA ASP.nET CORE RAZOR (NANRAKA TUTO TAO @YOUTUBE SY NIJERY TUTORILASPOINTS ARY NANAMPY TAO CHATGPT NANALA NY ERREUR)
