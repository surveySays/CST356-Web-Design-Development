<template>
  <div>


    

    <h2 id="index-heading">Index Page</h2>

    <img src="../assets/coast.jpg"  width="100%" height="400" />

    <div
      style="background-color:blue;text-align:center; width:100px; border-radius: 2px; cursor: pointer;"
      onclick="buttonClick()"
    >
      <p style="font-size: 25px; color:white">Button</p>
    </div>

    <h5>Paragraph 1 Heading</h5>

    <p>
      Lorem Ipsum is simply dummy text of the printing and typesetting industry.
      Lorem Ipsum has been the industry's standard dummy text ever since the
      1500s, when an unknown printer took a galley of type and scrambled it to
      make a type specimen book. It has survived not only five centuries, but
      also the leap into electronic typesetting, remaining essentially
      unchanged. It was popularised in the 1960s with the release of Letraset
      sheets containing Lorem Ipsum passages, and more recently with desktop
      publishing software like Aldus PageMaker including versions of Lorem
      Ipsum.
    </p>

    <h5>Paragraph 2 Heading</h5>

    <p>
      "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod
      tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim
      veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea
      commodo consequat. Duis aute irure dolor in reprehenderit in voluptate
      velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat
      cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id
      est laborum."
    </p>

    <h5>Paragraph 3 Heading</h5>

    <p>
      "On the other hand, we denounce with righteous indignation and dislike men
      who are so beguiled and demoralized by the charms of pleasure of the
      moment, so blinded by desire, that they cannot foresee the pain and
      trouble that are bound to ensue; and equal blame belongs to those who fail
      in their duty through weakness of will, which is the same as saying
      through shrinking from toil and pain. These cases are perfectly simple and
      easy to distinguish. In a free hour, when our power of choice is
      untrammelled and when nothing prevents our being able to do what we like
      best, every pleasure is to be welcomed and every pain avoided. But in
      certain circumstances and owing to the claims of duty or the obligations
      of business it will frequently occur that pleasures have to be repudiated
      and annoyances accepted. The wise man therefore always holds in these
      matters to this principle of selection: he rejects pleasures to secure
      other greater pleasures, or else he endures pains to avoid worse pains."
    </p>

    <!-- inject:js -->
    <!-- endinject -->
  </div>
</template>

<script>
export default {
  name: "Home",
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
#menu-items {
  list-style-type: none;
  text-decoration: none;
  color: #ffffff;
  font-size: 20px;
  padding: 5px;
}

#menu-items a {
  list-style-type: none;
  text-decoration: none;
  color: #000000;
  font-size: 20px;
  padding: 5px;
}

a:hover {
  background-color: yellow;
  border-radius: 2px;
  padding: 5px;
}

#menu {
  display: flex;
  justify-content: space-around;
  height: 100%;
  margin-top: -8px;
}

#big-button {
  margin-top: auto;
  margin-bottom: auto;
  align-items: center;
  align-content: center;
}

#form-log {
  width: 100%;
  justify-content: center;
  display: flex;
  text-align: center;
}

#username {
  border: 1px solid black;
}

#password {
  border: 1px solid black;
}

table {
  font-family: arial, sans-serif;
  border-collapse: collapse;
  width: 100%;
}

#index-heading {
  color: rgb(14, 41, 116);
  font-size: 24px;
}



</style>
