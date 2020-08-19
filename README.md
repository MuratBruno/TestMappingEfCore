# TestMappingEFCore

Ce projet est une API développée en ASP.NET CORE avec le framework Entity Framework,
le projet se concentre essentiellement sur a partie back pour l'instant.
Ce projet a pour but de m'exercer sur l'utilisation de l'orm Entity framework avec un model de donnée simple :
Un client peut faire plusieurs achats.
Ce projet me servira égalemment de base pour mes futurs projets c#. 

## Installation 

1 - Télécharger les outils nécessaires : Visual Studio Community, Git, Postman

2 – Télécharger le projet git : git clone https://github.com/MuratBruno/TestMappingEfCore.git

3 – Lancer le projet sur VS 2019 et vérifier ou installer les packages suivants (outils -> Gestionnaire de Package Nugget → Gérer les Packages Nugget) :

- Microsoft.EntityFrameworkCore 3.1.5

- Microsoft.EntityFrameworkCore.SqlServer 3.1.5

- Microsoft.EntityFrameworkCore.Tools 3.1.5

- Swashbuckle.AspNetCore.Swagger 5.5.0

- Swashbuckle.AspNetCore.SwaggerGen 5.5.0

- Swashbuckle.AspNetCore.SwaggerUI 5.5.0

4 – Lancer le projet, vérifier que l'adresse https://localhost:44375/  montre une page de bienvenue.

5 – Accéder à la liste des routes à l'adresse : https://localhost:44375/swagger 

## Avancement

### Sprint 1

- [x] Tests unitaires. (voir le projet TestMappingEfCoreTestsUnitaires)
- [x] Ajout des branches git : Develop, Release, Sprint, Tâche.
- [x] Ajout des couches model : Front (DTO), Métier (DBO), Données (DAO).
- [x] Manuel d'installation.

### Sprint 2

- [ ] Implémenter la relation Achat ↔ Client 
- [ ] Créer l'environnement docker : conteneur application + conteneur BDD

### Sprint 3

- [ ] Développement de la partie front avec blazor