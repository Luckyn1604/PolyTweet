package j2e.domain;

import java.util.Set;

import javax.jws.WebService;

@WebService
public interface MessageManager {
	public boolean delete(long id);
	public long create(String texte, String canal, String auteur);
	public Set<Long> afficherIdByTag(String canal);
	public String afficherTexteByID(long id);
	public String afficherAuteurByID(long id);
	public String afficherDateByID(long id); 
}
