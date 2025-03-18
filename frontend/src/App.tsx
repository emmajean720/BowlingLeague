// src/App.tsx
import React, { useEffect, useState } from 'react';
import Heading from './components/Heading';
import BowlerTable from './components/BowlerTable';
import { Bowler } from './types';

const API_URL = 'http://localhost:5009/api/Bowler'; // Replace with your API endpoint

const fetchBowlers = async (): Promise<Bowler[]> => {
    const response = await fetch(API_URL);
    if (!response.ok) {
        throw new Error('Failed to fetch bowlers');
    }
    const data = await response.json();
    return data;
};

const App: React.FC = () => {
    const [bowlers, setBowlers] = useState<Bowler[]>([]);

    useEffect(() => {
        const fetchData = async () => {
            try {
                const data = await fetchBowlers();
                setBowlers(data);
            } catch (error) {
                console.error('Error fetching bowlers:', error);
            }
        };

        fetchData();
    }, []);

    return (
        <div>
            <Heading />
            <BowlerTable bowlers={bowlers} />
        </div>
    );
};

export default App;
