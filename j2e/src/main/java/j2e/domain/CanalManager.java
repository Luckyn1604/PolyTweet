package j2e.domain;

import javax.jws.WebService;


@WebService
public interface CanalManager {
	
	public boolean supprimer(String tag);
	public String creer(String tagCanal ,String typeCanal, String proprietaireLogin);
	public boolean ajouterMessage(long message, String tagCanal);
	public boolean supprimerMessage(long message, String tagCanal);

}
