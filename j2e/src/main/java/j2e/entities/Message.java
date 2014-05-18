package j2e.entities;

import java.io.Serializable;
import java.util.Date;
import java.util.HashSet;
import java.util.Set;

import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.OneToMany;
import javax.persistence.Table;
import javax.persistence.Temporal;
import javax.persistence.TemporalType;


@Entity
@Table(name = "MESSAGES")
public class Message implements Serializable {

	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy = GenerationType.AUTO)
	@Column(name = "MESSAGES_id")
	private long id;
	
	@Column(name = "MESSAGES_texte")
	private String texte;
	
	@Column(name = "MESSAGES_date")
	@Temporal(TemporalType.TIMESTAMP)
	private Date date;
	
	@OneToMany(fetch=FetchType.EAGER,cascade=CascadeType.ALL,mappedBy = "message")
	private Set<PieceJointe> piecesJointes;
	
	@ManyToOne(fetch=FetchType.EAGER,cascade=CascadeType.ALL)
	@JoinColumn(name = "MESSAGES_canal")
	private Canal canal;

	@ManyToOne(fetch=FetchType.EAGER,cascade=CascadeType.ALL)
	@JoinColumn(name = "MESSAGES_auteur")
	private Utilisateur auteur;
	
	public Message() {}

	public Message(String texte, Canal canal, Utilisateur auteur) {
		this.texte = texte;
		this.piecesJointes = new HashSet<PieceJointe>();
		this.canal = canal;
		this.auteur = auteur;
		this.date = new Date();
	}

	public long getId() {
		return id;
	}

	public String getTexte() {
		return texte;
	}

	public Date getDate() {
		return date;
	}

	public Set<PieceJointe> getPiecesJointes() {
		return piecesJointes;
	}

	public Canal getCanal() {
		return canal;
	}

	public Utilisateur getAuteur() {
		return auteur;
	}
	
	@Override
	public boolean equals(Object obj) {
		if (obj instanceof Message){
			Message m = (Message)obj;
			return m.getId() == this.getId();
		}
		return false;
	}

	@Override
	public int hashCode() {
		return super.hashCode();
	}

	@Override
	public String toString() {
		return "Message{"
				+ " id = "+id
				+ ",auteur = " + auteur 
				+ "}";
	}
}
