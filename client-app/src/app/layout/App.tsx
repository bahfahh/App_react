import { useEffect, useState } from 'react'
import './style.css'
import axios from 'axios'
import { Container, Header, List } from 'semantic-ui-react';
import { Activity } from '../../model/activity';
import NavBar from '../NavBar';
import ActivityDashboard from '../../features/activities/dashboard/ActivityDashboard';
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
      <NavBar />
      <Container>
       <ActivityDashboard activities={activities} />
      </Container>
    </>
  )
}
export default App