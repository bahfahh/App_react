import React from 'react';
import { Grid, List } from 'semantic-ui-react';
import { Activity } from '../../../model/activity';
import ActivityList from './ActivityList';
interface Props {
    activities: Activity[];
}
export default function ActivityDashboard({ activities }: Props) {
    return (
        <Grid>
            <Grid.Column width={10}>
                <ActivityList activities={activities} />
            </Grid.Column>
        </Grid>
    );
}
