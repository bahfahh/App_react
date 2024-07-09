import { useEffect, useState } from 'react'
import './App.css'
import axios from 'axios'
import { Header, List } from 'semantic-ui-react';

interface Activity {
  id: number;
  title: string;
}

function App() {
  const [activities, setActivities] = useState<Activity[]>([])
  
  useEffect(() => {
    axios.get('http://localhost:5000/api/activities')
      .then(response => {
        setActivities(response.data)
      })
      .catch(error => {
        console.error("Error fetching activities:", error)
      })
  }, [])

  return (
    <>
      <div>
        <Header as='h2' icon='users' content='Reactivities' />
        <List> 
        <List.Item>
          {activities.map((activity: Activity) => (
            <li key={activity.id}>{activity.title}</li>
          ))}
        </List.Item>
        </List>
      </div>
    </>
  )
}

export default App