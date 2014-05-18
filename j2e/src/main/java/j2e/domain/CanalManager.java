package j2e.domain;

import java.util.Set;

import javax.jws.WebService;


@WebService
public interface CanalManager {
	
	public boolean supprimer(String tag);
	public String creer(String tagCanal ,String typeCanal, String proprietaireLogin);
	public boolean ajouterMessage(long message);
	public boolean supprimerMessage(long message);
	public Set<String> afficherTagByAbonne(String abonneLogin);
	public Set<String> afficherTagByType(String typeCanal);
	public boolean canalExiste(String tagCanal);
}
