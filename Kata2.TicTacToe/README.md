# StringCalculator

## Description

L'objectif de l'exercise est d'implementer une calculatrice avec les fonctionnalitées demandées. 
Cette calculatrice est a implementer dans la méthode add(String numbers) de la classe StringCalculator

## Règles

Avant de commencer :

* Faire les taches dans l’ordre
* Faire une tâche à la fois.
* Assurez-vous que vous testez seulement les entrées valides. Il n'y a pas besoin de tester les cas non valides.
* Il doit pas avoir des régressions sur les taches précédentes au cours de l’exercice.


## Exercice
 
* Compléter la méthode add pour accepter 0, 1 ou 2 chiffres et qui retourne leur somme (la chaîne vide retourne 0). Le caractère de séparation est la virgule.
```
Exemple : add("")=0, add("1")=1 ou add("1,2")=3
```
   
* Permettre à la méthode add d'accepter plus de deux nombres
```
Exemple : add("1,2,3")=6
```
   
* La méthode add peut gérer le retour à la ligne "\n".
```
ATTENTION : l'entrée suivante n’est PAS autorisée: "1,\n"
```
```
Exemple : add("1\n2,3")=6
```
   
* Différents séparateurs : la méthode peut accepter un séparateur different de la virgule, le début de la chaîne contiendra une ligne distincte qui ressemble à ceci: "//[séparateur]\[nombre ...]"
```
ATTENTION : la première ligne est facultative. tous les scénarios existants doivent encore être pris en charge.
```
```
Exemple : add("//;\n1;2")=3
```
       
* Si la chaine d'entrée contient un numéro négatif, la méthode add lance une exception avec le message suivant "negatives not allowed [numéros négatifs...]"
```
Exemple : add("1,-2") : "negatives not allowed -2"
```