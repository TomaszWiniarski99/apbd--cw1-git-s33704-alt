# apbd--cw1-git-s33704-alt
Fast-forward występuje wtedy, gdy gałąź docelowa nie ma nowych commitów od momentu utworzenia drugiej gałęzi. W takiej sytuacji Git tylko przesuwa wskaźnik gałęzi do przodu, bez tworzenia nowego commita.
Merge commit powstaje wtedy, gdy obie gałęzie mają nowe commity i ich historia się rozeszła. Git musi wtedy stworzyć specjalny commit scalający, który łączy historię obu gałęzi.

Merge łączy historię dwóch gałęzi poprzez utworzenie merge commit, który pokazuje moment scalenia. Historia zachowuje wszystkie rozgałęzienia.
Rebase przenosi commity z jednej gałęzi na koniec drugiej, przez co historia staje się liniowa, jakby wszystkie zmiany były wykonywane po kolei.

Konflikt pojawił się, ponieważ ta sama część kodu została zmodyfikowana zarówno w gałęzi main, jak i FeatureConflict.
Konflikt został rozwiązany poprzez ręczne edytowanie pliku i wybranie poprawnej wersji kodu (tej z main).

