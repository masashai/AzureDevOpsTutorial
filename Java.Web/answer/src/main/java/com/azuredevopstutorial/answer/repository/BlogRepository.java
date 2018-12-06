package com.azuredevopstutorial.answer.repository;

import java.util.List;

import org.seasar.doma.Dao;
import org.seasar.doma.Insert;
import org.seasar.doma.Select;
import org.seasar.doma.boot.ConfigAutowireable;

import com.azuredevopstutorial.answer.model.Blog;

@ConfigAutowireable
@Dao
public interface BlogRepository {
	@Select
	List<Blog> selectAll();	
	
	@Insert
	int insert(Blog blog);
}
