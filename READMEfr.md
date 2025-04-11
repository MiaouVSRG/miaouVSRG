<img src="https://github.com/MiaouVSRG/miaouVSRG/blob/master/interlude%2Fsrc%2FResources%2Fdefault%2FTextures%2Flogo%5B1x1%5D.png" align="left" height="400">

### MiaouVSRG c koi ??

Bah en gros c'est un VSRG (vertical scrolling rhythm game ou Jeu de rhythme a défilement vertical) dev par **Babil** et **Kyun** basé sur Interlude qui est un projet deja existant créé par percyqaz([yavsrg.net](https://www.yavsrg.net)).
<br/>
<br/>
Globalement tu peux importer les charts de stepmania,osu,etterna et quaver pour les jouer sur le client, tu peux aussi importer ton skin osu et faire des modifs nativement dans le client donc c'est cool nan ?
<br/>
<br/>
<br/>
<br/>
<br/>
<h2 align="center">😼 Jouer a le jeu 😼</h2>

On fera un des guides et un wiki soon probablement si toute fois on décide de foutre le projet public (ce qui m'etonnerais)  
Sinon ya le [wiki d'interlude](https://www.yavsrg.net/interlude/wiki) c'est sensiblemet la meme chose :3 

**Sur windows et linux** - Démerdez vous (m'enfin faut compiler et tout tsais)
<br/>
**Sur mac** - Allez vous faire foutre (réellement)

<h2 align="center">🧱 Fabriker MiaouVSRG 🧱</h2>

> [!Note]
>
> caca

1. Installer [Git](https://git-scm.com/downloads), et [le SDK .NET 9](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)  
juste tu suis les setup fin t'es pas con j'pense

2. Setup le repository

	fait ça dans un terminal:
	```bash
	# va a l'endroit ou tu veux télécharger le code - n'oublie pas --recurse-submodules!
	git clone https://github.com/MiaouVSRG/miaouVSRG.git --recurse-submodules
	```
	
3. run le CLI tool
	```bash
	cd miaouVSRG/tools
	dotnet run
	```
	Tu devrais voir dans ton terminal un truc du genre
	```
	== YAVSRG CLI Tools ==
	type 'help' for a list of commands, or help <command> for details
	>
	```

4. Quand vous etes dans le CLI tools, écrivez la commande `play` pour build et lancer la lastest version du jeu.  
   ça va créer un build du jeu sur `miaouVSRG/GAME` où il peut etre lancer directement. 

<img src="https://i.ibb.co/cXr93sQb/20250404-215447.jpg" align="left" height="800">
