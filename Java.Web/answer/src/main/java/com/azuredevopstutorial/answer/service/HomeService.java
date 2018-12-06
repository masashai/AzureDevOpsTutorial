package com.azuredevopstutorial.answer.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.azuredevopstutorial.answer.model.Blog;
import com.azuredevopstutorial.answer.repository.BlogRepository;

@Service
public class HomeService {
	@Autowired
	BlogRepository rep;
	
	public String greet(int hour)
	{
		String greeting = "";
		
		if (hour < 5) {
			greeting = "こんばんは";
		} else if (hour < 12) {
			greeting = "おはよう";
		} else if (hour < 18) {
			greeting = "こんにちは";
		} else {
			greeting = "こんばんは";
		}
		return greeting;
	}
	
	public List<Blog> getBlog() {
		return rep.selectAll();
	}
	
	public void addBlog(Blog blog) {
		rep.insert(blog);
	}
}
