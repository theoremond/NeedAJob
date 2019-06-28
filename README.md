# Maxime BRUCHET / Théo REMOND

## Jalon 1 :
	- [x] Installer Entity Framework 6 dans les projets nécessaires.
	- [x] Créer un répertoire pour stocker vos entités. 
	- [x] Créer les entités nécessaires conformément au modèle de données fourni (page 2) pour créer votre modèle.
	- [x] Réaliser le mapping entre les entités et la base de données. Ce mapping pourra se faire de deux façons (vous choisirez la méthode qui vous convient le mieux) :
	- [x] En utilisant l'API Fluent (conseillé).
	- [x] Créer un contexte Entity Framework pour avoir accès à votre base de données.
	- [x] Créer une couche d'accès aux données :
	- [x] Manager + Query / Command (conseillé).
	- [x] Service avec interface.
	- [x] Tester unitairement sur une entité du modèle en réalisant les opérations suivantes : ajout, modification, suppression, get

## Jalon 2 :
	- [x] Créer une application WPF avec l’architecture nécessaire pour utiliser le patron de conception MVVM.
	- [x] Ajouter une référence à la couche d’accès au modèle précédemment créée pour disposer du modèle et donc des objets métiers. N'oubliez pas d'ajouter à accès à votre Business Layer pour bénéficier de vos requêtes et de vos commandes.
	- [x] Mise en place du ou des écran(s) étudié(s) en TD :
	- [x] A gauche, une ListView pour avoir une liste d'offre.
	- [x] A droite, le détail de l'offre sélectionnée dans la ListView.
	- [x] Par défaut, la première offre sélectionnée est la première offre de la liste.
	- [x] Un filtre sur le statut de l'offre.
	- [x] Pensez à trier votre liste d'offre de manière intelligente.
	- [x] Le détail de l'offre devra intégrer la liste des postulants (nom et prénom de l'employé qui a postulé au minimum).
	- [x] Mise en place de la modification d'une offre (exemple : modification du salaire) dans l'écran de détail.
	- [] Ajouter la possibilité de créer une offre directement dans l'application.

##Jalon 3:
	- [x] Créer un projet de type service WCF pour créer un web service permettant de :
	- [x] Mettre à disposition les offres disponibles pour les employés (GET).
	- [] (BONUS) Envoyer une demande de postulation à une offre (POST).
	- [x] Le service doit être de type REST.
	- [x] Le fichier WSDL doit être accessible comme décrit en cours.
	- [x] Ajouter une référence à la couche d’accès au modèle précédemment créée pour disposer du modèle et donc des objets métiers (Il faudra au préalable surcharger ces objets métiers pour gérer les contrats et les membres du contrat).
	- [x] Une commande à livrée se déduit à l'aide du statut de la commande.

##Jalon 4:
	- [x] Créer un projet type ASP.NET MVC.
	- [x] Consulter une liste d'offre.
	- [x] Rechercher une offre.
	- [x] Consulter le détail d'une offre.
	- [x] Postuler sur une offre.
	- [x] Consulter la liste des postulations de l'employé actuellement connecté.
