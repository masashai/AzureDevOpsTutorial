package com.azuredevopstutorial.answer.model;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;

import lombok.Data;

@Entity
@Data
public class Blog {

	@Id
	@GeneratedValue
	public Integer blogId;

	public String name;

	public String author;
}
