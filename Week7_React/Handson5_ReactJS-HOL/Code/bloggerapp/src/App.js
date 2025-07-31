import React, { useState } from 'react';
import './App.css';
import BookDetails from './BookDetails';
import BlogDetails from './BlogDetails';
import CourseDetails from './CourseDetails';

function App() {
  const [section, setSection] = useState('book');

  return (
    <div className="App">
      <h1>Blogger App</h1>

      <div>
        <button onClick={() => setSection('book')}>Show Book</button>
        <button onClick={() => setSection('blog')}>Show Blog</button>
        <button onClick={() => setSection('course')}>Show Course</button>
      </div>

      <BookDetails show={section === 'book'} />
      <BlogDetails show={section === 'blog'} />
      <CourseDetails show={section === 'course'} />
    </div>
  );
}

export default App;
