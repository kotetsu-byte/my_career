<template>
    <div class="container">
        <p>Educations</p>
        <p>Freelancers who add their experience are twice as likely to win work. But if you’re just starting out, you can still create a great profile. Just head on to the next page.</p>
        <div class="education">
            <p>TATU</p>
            <p>Bachelor</p>
            <p></p>
            <p>Telecommunication</p>
            <button>Edit</button>
            <button>Delete</button>
        </div>
        <button>+ Add new</button><br>
        <div style="text-align: right;">
            <button @click="prev(5)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Back</button>
            <button @click="next(7)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Next</button>
        </div>
    </div>
</template>

<script>
export default {
    name: 'Component6',
    components: {},
    props: {
        
    },
    data() {
        return {
            
        }
    },
    methods: {

    },
    computed: {

    },
    mounted() {

    }
}
</script>

<style scoped>
.container {
    margin: 100px auto 0 auto;
    min-width: 400px;
    max-width: max-content;
    background-color: white;
    border-radius: 12px;
    padding: 20px;
    width: max-content;
    max-width: 500px;
}
</style>