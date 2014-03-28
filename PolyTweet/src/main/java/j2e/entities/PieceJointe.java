package j2e.entities;

import java.io.File;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.ManyToOne;
import javax.persistence.Table;


@Entity
@Table(name = "piece_jointe")
public class PieceJointe {

	@Column(name = "fichier")
	private File fichier;
	
	@ManyToOne
	@Column(name = "message")
	private Message message;

	public PieceJointe(File fichier, Message message) {
		super();
		this.fichier = fichier;
		this.message = message;
	}

	public File getFichier() {
		return fichier;
	}

	public Message getMessage() {
		return message;
	}
	
}