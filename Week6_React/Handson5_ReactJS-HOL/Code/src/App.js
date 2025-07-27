import React from 'react';
import { CohortsData } from './Cohort';
import CohortDetails from './CohortDetails';
import styles from './CohortDetails.module.css';

function App() {
  return (
    <div>
      <h1 style={{ textAlign: 'center' }}>Cohort Dashboard</h1>
      <div className={styles.dashboard}>
        {CohortsData.map((cohort, index) => (
          <CohortDetails key={index} cohort={cohort} />
        ))}
      </div>
    </div>
  );
}

export default App;
