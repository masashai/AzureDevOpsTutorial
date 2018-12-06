package com.azuredevopstutorial.answer.model;

import org.seasar.doma.Entity;
import org.seasar.doma.GeneratedValue;
import org.seasar.doma.GenerationType;
import org.seasar.doma.Id;
import org.seasar.doma.Table;

@Entity
@Table
public class Blog {

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	public int blogId;

	public String name;

	public String author;
}
