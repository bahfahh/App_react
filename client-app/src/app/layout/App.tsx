import { useEffect, useState } from 'react'
import './style.css'
import axios from 'axios'
import { Header, List } from 'semantic-ui-react';
import { Activity } from '../../model/activity';
import NavBar from '../NavBar';

function App() {
  const [activities, setActivities] = useState<Activity[]>([])
  useEffect(() => {
    axios.get<Activity[]>('http://localhost:5000/api/activities')
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
        <NavBar/>
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