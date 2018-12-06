package com.azuredevopstutorial.answer;

import static org.hamcrest.CoreMatchers.*;
import static org.junit.Assert.assertThat;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.test.context.junit4.SpringRunner;

import com.azuredevopstutorial.answer.service.HomeService;

@RunWith(SpringRunner.class)
@SpringBootTest
public class AnswerApplicationTests {

	@Autowired
	HomeService service;
	
	@Test
	public void greet_11_goodmorning() {
		// Arrange・Act
		String actual = service.greet(11);
		
		// Assert
		assertThat(actual, is("おはよう"));
	}
	
	@Test
	public void greet_12_hello() {
		// Arrange・Act
		String actual = service.greet(12);
		
		// Assert
		assertThat(actual, is("こんにちは"));
	}
	
	@Test
	public void greet_18_goodevening() {
		// Arrange・Act
		String actual = service.greet(18);
		
		// Assert
		assertThat(actual, is("こんばんは"));
	}
	
	@Test
	public void greet_2_goodevening() {
		// Arrange・Act
		String actual = service.greet(2);
		
		// Assert
		assertThat(actual, is("こんばんは"));
	}

}
