package com.azuredevopstutorial.answer.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.azuredevopstutorial.answer.model.Blog;

@Repository
public interface BlogRepository extends JpaRepository<Blog, Integer> {
	
}
