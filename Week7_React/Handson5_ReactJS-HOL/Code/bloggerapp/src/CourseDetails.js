import React from 'react';

function CourseDetails({ show }) {
  return show && (
    <div className='details-box'>
      <h2>Course Details</h2>
      <p>Title: React Mastery</p>
      <p>Instructor: John Smith</p>
      <p>Duration: 8 weeks</p>
    </div>
  );
}

export default CourseDetails;
