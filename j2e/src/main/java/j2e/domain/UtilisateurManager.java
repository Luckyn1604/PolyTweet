package j2e.domain;

import java.util.Set;

import javax.jws.WebService;


@WebService
public interface UtilisateurManager {
	
	public boolean delete(String login);
	public String create(String login);
	public boolean demandeAbonnement(String utilisateur, String tagChannel);
    public boolean accepterAbonnement(String donneur,String receveur, String tagCanal);
    public boolean refuserAbonnement(String donneur,String receveur, String tagCanal);
	public boolean ajouterModerateur(String donneur, String receveur,String tagCanal);
	public boolean supprimerModerateur(String donneur, String receveur,String tagCanal);
	public boolean ajouterProprietaire(String donneur, String receveur,String tagCanal);
	public boolean supprimerProprietaire(String donneur, String receveur,String tagCanal);
    public boolean ajouterMessage(String utilisateur, long message, String tagCanal);
    public boolean supprimerMessage(String utilisateur, long message, String tagCanal);
    public Set<Long> consulterMessages(String utilisateur, String tagCanal);



}
