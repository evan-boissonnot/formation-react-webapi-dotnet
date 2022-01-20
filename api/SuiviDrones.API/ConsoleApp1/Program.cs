using DecouverteInjectionDependances;


Voiture voiture = new ();
Velo velo = new ();
Trotinnette trotinnette = new ();


Humain humain = new Humain(voiture);

DateTime date = DateTime.Now;

humain.EmmenerEnfants(voiture);
humain.EmmenerEnfants(velo);
humain.EmmenerEnfants(trotinnette);
